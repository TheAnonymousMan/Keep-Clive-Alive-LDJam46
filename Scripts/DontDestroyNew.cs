using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyNew : MonoBehaviour
{
    void Awake()
    {
        Destroy(GameObject.Find("CalmMusic"));
        DontDestroyOnLoad(this.gameObject);
    }
}