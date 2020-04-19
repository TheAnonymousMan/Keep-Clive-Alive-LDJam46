using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAgain : MonoBehaviour
{
    void Awake()
    {
        Destroy(GameObject.Find("SombreMusic"));
        DontDestroyOnLoad(this.gameObject);
    }
}