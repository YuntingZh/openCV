using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour
{
	public float speed;
	private bool bTrigger = false;
	private GameObject objTrigger;
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (bTrigger)
		{
			objTrigger.transform.Rotate(Vector3.up * 20 * Time.deltaTime);
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "food")
		{
			Destroy(other.gameObject);
			Debug.Log("成功拾取物体");
		}
		if (other.tag == "Coin")
		{
			other.transform.Translate(-Vector3.right * speed, Camera.main.transform);

		}
		if (other.tag == "Finish")
		{
			bTrigger = true;
			objTrigger = other.gameObject;
		}
		/*	Debug.Log(" Trigger enter");*/
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Finish")
		{
			if (Input.GetKey(KeyCode.Mouse1))
			{
				other.transform.Rotate(Vector3.up * 20 * Time.deltaTime);
			}
		}

	}
}

