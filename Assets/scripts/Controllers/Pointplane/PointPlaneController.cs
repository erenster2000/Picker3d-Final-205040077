using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Controllers.Pointplane
{
    

public class PointPlaneController : MonoBehaviour
{
    private float timer;
    private bool pointTaken;
    private bool playerInside;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            timer = 0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            timer = 0f;
        }
    }

    void Update()
    {
        if (playerInside == true)
        {   
            if(pointTaken == false)
            {
            timer += Time.deltaTime;

                if (timer >= 2f)
                {
                    Debug.Log("+100 GEM");
                    timer = 0f;
                    pointTaken = true;
                }
            }
        }
    }
}

}