using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_First : MonoBehaviour
{
    [HideInInspector]
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    public float speed = 1.0f;
    public SpriteRenderer spriterenderer;

    void Start()
    {
        lastWaypointSwitchTime = Time.time;
        transform.DOMove(waypoints[Random.Range(1, 9)].transform.position, 2f).OnComplete(() => { Destroy(gameObject); });
    }
}
