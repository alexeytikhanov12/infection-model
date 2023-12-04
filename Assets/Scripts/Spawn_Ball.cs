using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Spawn_Ball : MonoBehaviour
{
    public GameObject[] waypoints;
    public Movie_Ball testEnemyPrefab;
    public Text textElement;
    public int healthy;
    public int patients;
    public Spawn_Ball[] Balls;
    int rand;
    public int index_waypoint;

    void Start()
    {
        textElement.text = $"Количество здоровых: {healthy}" + Environment.NewLine + $"Количество больных: {patients}";
        StartCoroutine(Spawn_Cycle());
    }

    private void Update()
    {
        textElement.text = $"Количество здоровых: {healthy}" + Environment.NewLine + $"Количество больных: {patients}";
    }

    private IEnumerator Spawn_Cycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(1f,3f));
            Movie_Ball movie_ = Instantiate(testEnemyPrefab, waypoints[index_waypoint].transform.position, Quaternion.identity);

            if (patients != 0 && healthy != 0)
            {
                rand = UnityEngine.Random.Range(1, 3);
            }
            else if (patients == 0 && healthy != 0)
            {
                rand = 2;
            }
            else if (patients != 0 && healthy == 0)
            {
                rand = 1;
            }
            //else
            //{
                
            //}


            if (rand == 1 && patients != 0)
            {
                movie_.spriterenderer.color = Color.red;
                movie_.trailRenderer.startColor = Color.red;
                movie_.trailRenderer.endColor = Color.red;
                patients--;
            }
            else if (rand == 2 && healthy != 0)
            {
                healthy--;

            }
            movie_.waypoints = waypoints;
            movie_.targets = Balls;
            movie_.StartIndex = index_waypoint;
            movie_.Start_Movie();
        }
    }
}
