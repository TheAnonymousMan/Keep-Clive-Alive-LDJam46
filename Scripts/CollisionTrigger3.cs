using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger3 : MonoBehaviour
{
    public Animator CliveAnimator;
    public GameObject[] deadText;

    public AudioSource audioSource;

    public AudioClip deadSound;
    
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Front Car")
        {
            Debug.Log("Touch Car");

            audioSource.PlayOneShot(deadSound);

            CliveAnimator.SetTrigger("Kill");

            deadText[0].SetActive(true);
            yield return new WaitForSeconds(2);
            deadText[0].SetActive(false);

            deadText[1].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = true;
            Flags.Save = false;

            SceneManager.LoadScene("Scene3");
        }
    }
}
