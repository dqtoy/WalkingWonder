using UnityEngine;
using System.Collections;

public class Serveillance : MonoBehaviour
{
	void Start()
	{
		//transform.localScale = new Vector3(-1, 1, 1);
	}

	void Update()
	{
		transform.LookAt(Camera.main.transform);
	}
}