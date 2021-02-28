using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public float sensitivity = 1F;
	private Camera goCamera;
	private Vector3 MousePos;
	private float MyAngle = 0F;
	// Use this for initialization
	void Start()
	{
		offset = player.transform.position;
		
	}
	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position ;
	}

	void Update()
    {
		MousePos = Input.mousePosition;
	}

}
