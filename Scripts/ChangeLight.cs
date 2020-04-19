using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLight : MonoBehaviour
{
    public Animator[] animators;
    public AudioSource audioSource;
    public GameObject[] aliveText;
    public AudioClip aliveSound;

    private void Start()
    {
        StartCoroutine(waitfor4secs());
    }

    private IEnumerator waitfor4secs()
    {
        yield return new WaitForSeconds(3);
        GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(1f);
        GetComponent<BoxCollider2D>().enabled = false;
    }

    private IEnumerator OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Signal Clicked.");
            foreach (Animator animator in animators)
            {  
                animator.SetTrigger("Save");
            }

            yield return new WaitForSeconds(0.25f);

            audioSource.PlayOneShot(aliveSound);

            yield return new WaitForSeconds(1.15f);
        
            aliveText[0].SetActive(true);
            yield return new WaitForSeconds(3);
            aliveText[0].SetActive(false);

            aliveText[1].SetActive(true);
            yield return new WaitForSeconds(3);
            aliveText[1].SetActive(false);

            aliveText[2].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = false;
            Flags.Save = true;

            SceneManager.LoadScene("Scene6 Drowning");
        }
    }
}
