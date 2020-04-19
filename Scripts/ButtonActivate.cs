using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitAndActivate());
    }

    private IEnumerator waitAndActivate()
    {
        yield return new WaitForSeconds(12.25f);
        button1.SetActive(true);
        button2.SetActive(true);
    }
}
