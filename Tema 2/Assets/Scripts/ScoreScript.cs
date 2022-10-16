using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float score;
    public Image scoreBackground;
    public GameObject winImage;
    // Start is called before the first frame update
    void Start()
    {
        winImage.SetActive(false);
        score=0;
        scoreBackground.fillAmount = score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreIncrease(float points)
    {
        score +=points;
        scoreBackground.fillAmount = score;

        if(score>=1)
        {
           winImage.SetActive(true); 
        }
    }
}
