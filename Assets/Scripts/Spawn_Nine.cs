using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn_Nine : MonoBehaviour
{
    public GameObject[] waypoints;
    public Move_Nine testEnemyPrefab;
    public Text textElement;
    public int healthy;
    public int patients;
    int rand;

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
        textElement.text = $"Количество здоровых: {healthy}" + Environment.NewLine + $"Количество больных: {patients}";
        StartCoroutine(Spawn_Cycle());
    }

    private IEnumerator Spawn_Cycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Move_Nine movie_ = Instantiate(testEnemyPrefab, waypoints[8].transform.position, Quaternion.identity);

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
            else
            {
                yield break;
            }


            if (rand == 1 && patients != 0)
            {
                movie_.spriterenderer.color = Color.red;
                patients--;
            }
            else if (rand == 2 && healthy != 0)
            {
                healthy--;
            }
            textElement.text = $"Количество здоровых: {healthy}" + Environment.NewLine + $"Количество больных: {patients}";
            movie_.waypoints = waypoints;
            movie_.sfc = sfc;
            movie_.ssc = ssc;
            movie_.sth = sth;
            movie_.sf = sf;
            movie_.sfi = sfi;
            movie_.ssx = ssx;
            movie_.ssev = ssev;
        }
    }
}
