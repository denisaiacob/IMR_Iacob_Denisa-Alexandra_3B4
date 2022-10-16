using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPoints : MonoBehaviour
{
    public GameObject tenPoints;
    public GameObject twentyPoints;
    public float numberOfPoints;
    void Start()
    {
        tenPoints.SetActive(false);
        twentyPoints.SetActive(false);
    }

    void Update()
    {
        
    }

    public void SetPoints(float points)
    {
        numberOfPoints=points;
    }

    void OnTriggerEnter(Collider target)
    {
        if(target.gameObject.tag=="Target")
        {
            if(numberOfPoints==10)
            {
                tenPoints.SetActive(true);
                StartCoroutine("WaitForSec");
                target.gameObject.GetComponent<ScoreScript>().ScoreIncrease(0.17f);
            }
            else
            {
                twentyPoints.SetActive(true);
                StartCoroutine("WaitForSec");
                target.gameObject.GetComponent<ScoreScript>().ScoreIncrease(0.34f);
            }
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        tenPoints.SetActive(false);
        twentyPoints.SetActive(false);
    }

}
