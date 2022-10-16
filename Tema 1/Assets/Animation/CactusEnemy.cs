using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusEnemy : MonoBehaviour
{
    private Animator mAnimator;
    
    void Start()
    {
        mAnimator=GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag=="Cactus")
        {
             mAnimator.SetTrigger("get_hit");
            //  mAnimator.SetTrigger("dead");
        }
    }
}
