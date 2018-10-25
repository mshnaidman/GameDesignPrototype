using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 35;
    int MinDist = 0;
    float endTime = .1f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);


        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        

      
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("hit");
            while (endTime < (Time.deltaTime + endTime))
            {
                transform.position = -transform.position;
                print("in loop");
            }

        }

    }
}

