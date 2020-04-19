using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger5 : MonoBehaviour
{
    public Animator CliveAnimator;
    public GameObject[] deadText;

    public AudioSource audioSource;

    public AudioClip deadSound;
    public GameObject[] aliveText;
    public AudioClip aliveSound;

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.name == "Trampoline")
        {
            Debug.Log("Touch Tramp");

            audioSource.PlayOneShot(deadSound);

            deadText[0].SetActive(true);
            yield return new WaitForSeconds(2);
            deadText[0].SetActive(false);

            deadText[1].SetActive(true);
            yield return new WaitForSeconds(2);
            deadText[1].SetActive(false);

            Flags.Kill = false;
            Flags.Save = true;

            CliveAnimator.ResetTrigger("Kill");

        }
        else if (collision.name == "EndGame")
        {
            aliveText[0].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            aliveText[0].SetActive(false);

            aliveText[1].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            aliveText[1].SetActive(false);

            aliveText[2].SetActive(true);
            yield return new WaitForSeconds(3);

            SceneManager.LoadScene("EndScene");

        }
    }
}
