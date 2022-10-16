using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject target;
    public GameObject ball;
    public float Distance_;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            // startTime = Time.timeAsDouble;
            Distance_ = Vector3.Distance(target.transform.position, ball.transform.position);
            if(Distance_<3.5)
                ball.gameObject.GetComponent<ShowPoints>().SetPoints(10);
            else
                ball.gameObject.GetComponent<ShowPoints>().SetPoints(20);
        }
    }
}
