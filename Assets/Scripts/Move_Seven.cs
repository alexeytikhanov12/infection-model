using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move_Seven : MonoBehaviour
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
        int[] wayp = { 0, 1, 2, 3, 4, 5, 7, 8 };
        transform.DOMove(waypoints[wayp[Random.Range(0, 8)]].transform.position, 2f).OnComplete(() => { Destroy(gameObject); });
    }
}
