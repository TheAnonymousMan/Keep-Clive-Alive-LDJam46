using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{
    public Animator CliveAnimator;
    public GameObject[] deadText;

    public AudioSource audioSource;

    public AudioClip deadSound;
    public GameObject[] aliveText;
    public AudioClip aliveSound;

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Ground")
        {
            Debug.Log("Touch Ground");

            audioSource.PlayOneShot(deadSound);

            CliveAnimator.SetTrigger("Kill");

            deadText[0].SetActive(true);
            yield return new WaitForSeconds(2);
            deadText[0].SetActive(false);

            deadText[1].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = true;
            Flags.Save = false;

            SceneManager.LoadScene("Scene1");
        }
        else if(collision.name == "Trampoline")
        {
            Debug.Log("Touch Tramp");

            audioSource.PlayOneShot(aliveSound);

            CliveAnimator.SetTrigger("Save");

            aliveText[0].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            aliveText[0].SetActive(false);

            aliveText[1].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            aliveText[1].SetActive(false);

            aliveText[2].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = false;
            Flags.Save = true;

            SceneManager.LoadScene("Scene2");
        }
    }
}
