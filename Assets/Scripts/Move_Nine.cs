using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move_Nine : MonoBehaviour
{
    [HideInInspector]
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    public float speed = 1.0f;
    public SpriteRenderer spriterenderer;

    public Spawn_First_City sfc;
    public Spawn_Second_City ssc;
    public Spawn_Third sth;
    public Spawn_Four sf;
    public Spawn_Five sfi;
    public Spawn_Six ssx;
    public Spawn_Seven ssev;
    public Spawn_Eight seig;
    public Spawn_Nine sni;

    void Start()
    {
        lastWaypointSwitchTime = Time.time;
        int[] wayp = { 0, 1, 2, 3, 4, 5, 6, 7 };
        int way_point = wayp[Random.Range(0, 8)];
        transform.DOMove(waypoints[way_point].transform.position, 2f).OnComplete(() => 
        {
            if(way_point == 0)
            {
                if(spriterenderer.color == Color.white)
                {
                    sfc.healthy++;
                }
                else
                {
                    sfc.patients++;
                }
            }
            else if (way_point == 1)
            {
                if (spriterenderer.color == Color.white)
                {
                    ssc.healthy++;
                }
                else
                {
                    ssc.patients++;
                }
            }
            else if (way_point == 2)
            {
                if (spriterenderer.color == Color.white)
                {
                    sth.healthy++;
                }
                else
                {
                    sth.patients++;
                }
            }
            else if (way_point == 3)
            {
                if (spriterenderer.color == Color.white)
                {
                    sf.healthy++;
                }
                else
                {
                    sf.patients++;
                }
            }
            else if (way_point == 4)
            {
                if (spriterenderer.color == Color.white)
                {
                    sfi.healthy++;
                }
                else
                {
                    sfi.patients++;
                }
            }
            else if (way_point == 5)
            {
                if (spriterenderer.color == Color.white)
                {
                    ssx.healthy++;
                }
                else
                {
                    ssx.patients++;
                }
            }
            else if (way_point == 6)
            {
                if (spriterenderer.color == Color.white)
                {
                    ssev.healthy++;
                }
                else
                {
                    ssev.patients++;
                }
            }
            else if (way_point == 7)
            {
                if (spriterenderer.color == Color.white)
                {
                    seig.healthy++;
                }
                else
                {
                    seig.patients++;
                }
            }
            Destroy(gameObject); 
        });
    }
}
