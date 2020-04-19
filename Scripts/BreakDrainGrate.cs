using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakDrainGrate : MonoBehaviour
{
    int breakcounter;

    public GameObject[] keepDoingText;

    public Animator waterAnimator;
    public Animator drainPipeAnimator;

    //public GameObject drainPipe;

    // Start is called before the first frame update
    void Start()
    {
        breakcounter = 4;
    }

    private void OnMouseDown()
    {
        if(breakcounter == 0)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            setAppropriateTriggers();
            keepDoingText[4 - breakcounter - 1].SetActive(false);
        }
        else
        {
            if ((4 - breakcounter) > 0)
            {
                keepDoingText[4 - breakcounter - 1].SetActive(false);
            }
            keepDoingText[4 - breakcounter].SetActive(true);
            breakcounter -= 1;
        }
        
    }

    private void setAppropriateTriggers()
    {
        waterAnimator.SetTrigger("Drain");
        drainPipeAnimator.SetTrigger("Drain");
    }
}
