using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void Update()
	{
		transform.Rotate(new Vector3(15, 35, 28) * Time.deltaTime);
	}
}
