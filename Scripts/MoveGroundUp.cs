using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGroundUp : MonoBehaviour
{
	public float upwardShift = 0.1f;
	public float heightRequired = 4f;
	// Start is called before the first frame update
	void Start()
	{
		print("Hello, World.");
		print(transform.position.x);
	}
	void OnMouseDown()
	{
		if (heightRequired <= 0.0)
		{
			print("Clive is safe.");
			return;
		}
		GameObject target = GameObject.Find("Ground");
		print(target.transform.position.x);
		Vector3 mov = new Vector3(0.0f, upwardShift, 0f);
		target.transform.position += mov;
		heightRequired -= upwardShift;
		print("Click registered.");
	}

	// Update is called once per frame
	void Update()
	{
		// if (Input.GetKeyDown(KeyCode.LeftArrow))
		// {
		// 	Vector3 pos = transform.position;
		// 	pos.x++;
		// 	transform.position = pos;
		// }
	}
}
