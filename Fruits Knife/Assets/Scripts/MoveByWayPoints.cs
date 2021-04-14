﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByWayPoints : MonoBehaviour
{

    public Transform[] wayPoints;
    public float speed = 3;
    public int index = 0;

    public bool isClockWise=true;


    private void Update()
    {
        if(wayPoints!=null)
        {
            if(isClockWise)
            {
                if (Vector2.Distance(wayPoints[index].position, transform.position) < 0.1f)
                {
                    if (index + 1 >= wayPoints.Length)
                        index = 0;
                    else
                        index++;
                }
                else
                    transform.position = Vector2.MoveTowards(transform.position, wayPoints[index].position, speed * Time.deltaTime);
            }
            else
            {
                if (Vector2.Distance(wayPoints[index].position, transform.position) < 0.1f)
                {
                    if (index  <= 0)
                        index = wayPoints.Length-1;
                    else
                        index--;
                }
                else
                    transform.position = Vector2.MoveTowards(transform.position, wayPoints[index].position, speed * Time.deltaTime);


            }

        }
    }
   
}
