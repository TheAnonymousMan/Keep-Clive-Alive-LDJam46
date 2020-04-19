﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedTrigger : MonoBehaviour
{
    public float timeLeft;
    public Animator targetAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Animate();
        }
    }

    void Animate()
    {
        targetAnimator.SetTrigger("KillSelf");
    }
}
