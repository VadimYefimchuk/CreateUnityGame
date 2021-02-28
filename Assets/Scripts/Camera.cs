using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start()
	{
		offset = player.transform.position;
	}
	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position ;

		Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 5.0f, Vector3.up);
		offset = camTurnAngle * offset;
	}

}
