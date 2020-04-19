using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTrigger : MonoBehaviour
{
    public float timeLeft;
    public Animator ChairAnimator;
	public Animator CliveAnimator;
	bool fallen = false;

    // Start is called before the first frame update
    void Start()
    {
        fallen = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Animate();
        }
    }

    void Animate()
    {
		if (fallen)
		{
			// CliveAnimator.ResetTrigger("Swing");
			return;
		}
		if (!fallen)
			ChairAnimator.SetTrigger("Fall");
		fallen = true;
		print("Chair is falling.");
		GameObject Clive = GameObject.Find("Clive_Shu");
		print(Clive.transform.position.x);
		Vector3 mov = new Vector3(1f, 0f, 0f);
		Clive.transform.eulerAngles += new Vector3(0, 0, 30);
		print(Clive.transform.rotation.z);
		// CliveAnimator.SetTrigger("Swing");
		print("Clive is swinging.");
    }
}
