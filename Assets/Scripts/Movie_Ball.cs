using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movie_Ball : MonoBehaviour
{
    [HideInInspector]
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    public float speed = 1.0f;
    public SpriteRenderer spriterenderer;
    public Spawn_Ball[] targets;
    public TrailRenderer trailRenderer;
    public int StartIndex;


    public void Start_Movie()
    {
        lastWaypointSwitchTime = Time.time;
        int way_point = Random.Range(0, 9);
        while (way_point == StartIndex)
        {
            way_point = Random.Range(0, 9);
        }

        transform.DOMove(waypoints[way_point].transform.position, Random.Range(1f, 3f)).OnComplete(() => 
        {
            if (spriterenderer.color == Color.white)
            {
                targets[way_point].healthy++;
            }
            else
            {
                targets[way_point].patients++;
            }

            Destroy(gameObject); 
        });
    }
}
