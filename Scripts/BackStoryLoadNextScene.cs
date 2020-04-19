using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackStoryLoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadNextScene());
    }

    private IEnumerator loadNextScene()
    {
        yield return new WaitForSeconds(24);
        SceneManager.LoadScene("Scene3");
    }
}