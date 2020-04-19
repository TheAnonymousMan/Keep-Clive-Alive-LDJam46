using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimTrigger : MonoBehaviour
{
    public Animator animator;

    public void setAnimeTrigger()
    {
        animator.SetTrigger("Kill");
    }
}
