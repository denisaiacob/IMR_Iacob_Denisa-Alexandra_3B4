using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusAttack : MonoBehaviour
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
        if(collider.tag=="Enemy")
        {
             mAnimator.SetTrigger("attack");
        }
    }
}
