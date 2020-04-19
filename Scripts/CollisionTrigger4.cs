using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger4 : MonoBehaviour
{
    public float timeLeft = 5f;
    public static bool fired = false;

    public Animator CliveAnimator;
    public Animator BulletAnimator;
    public GameObject[] deadText;

    public AudioSource audioSource;

    public AudioClip deadSound;
    public GameObject[] aliveText;
    public AudioClip aliveSound;

    void Start()
    {
        fired = false;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0 && !fired)
        {
            fired = true;
            print("Firing.");
			Driver();
        }
    }
    
	void Driver()
	{
		StartCoroutine (FuncToFire());
	}

    private IEnumerator FuncToFire()
    {
//        return;
        print(Flags.Eject);
        print("Within function");
        if (Flags.Eject == false)
        {
            print("Fire gun");

            audioSource.PlayOneShot(deadSound);

            Debug.Log("Bullet Fires");

            // audioSource.PlayOneShot(deadSound);

            BulletAnimator.SetTrigger("Fire");
            CliveAnimator.SetTrigger("Shot");

            deadText[0].SetActive(true);
            yield return new WaitForSeconds(2);
            deadText[0].SetActive(false);

            deadText[1].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = true;
            Flags.Save = false;

            SceneManager.LoadScene("Scene4");
        }
        else
        {
            Debug.Log("Mag Removed.");

            audioSource.PlayOneShot(aliveSound);

            // audioSource.PlayOneShot(deadSound);

            // BulletAnimator.SetTrigger("Fire");
            // CliveAnimator.SetTrigger("Shot");

            aliveText[0].SetActive(true);
            yield return new WaitForSeconds(2);
            aliveText[0].SetActive(false);

            aliveText[1].SetActive(true);
            yield return new WaitForSeconds(3);
            aliveText[1].SetActive(false);

            aliveText[2].SetActive(true);
            yield return new WaitForSeconds(3);

            Flags.Kill = true;
            Flags.Save = false;

            SceneManager.LoadScene("Scene7 Wrist Slashing");

        }
    }
}
