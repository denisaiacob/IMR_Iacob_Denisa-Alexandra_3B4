using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScripts : MonoBehaviour
{
    private Animator mAnimator;
    bool leftHand=false;
    bool rightHand=false;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator=GetComponent<Animator>();
        mAnimator.SetBool("RightHand",false);
        mAnimator.SetBool("LeftHand",false);
    }

    // Update is called once per frame
    void Update()
    {
        while(Input.GetKeyDown("space"))
        {
            mAnimator.SetBool("RightHand",true);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            mAnimator.SetBool("LeftHand",true);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            mAnimator.SetTrigger("Grab");
        }
    }
}

