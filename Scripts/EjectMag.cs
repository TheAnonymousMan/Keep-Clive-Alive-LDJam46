using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectMag : MonoBehaviour
{
	public Animator Mag;

	public AudioSource MagSound;
	public AudioClip MagRemove;
	public AudioClip MagDropSound;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void OnMouseDown()
	{
		Mag.SetTrigger("Eject");

		MagSound.PlayOneShot(MagRemove);

		StartCoroutine(MagDrop());

		Flags.Eject = true;
	}

	private IEnumerator MagDrop()
	{
		yield return new WaitForSeconds(1);
		MagSound.PlayOneShot(MagDropSound);
	}
}
