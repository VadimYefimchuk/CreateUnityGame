using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public Text countText, winText, countToWin;
	/// кількість зібраних кубів
	private int count, cubeToWin;
	/// Початкова кількість кубів
	private int countCoub;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0; /// по замовчуванням зібрано 0 кубів
		winText.text = ""; /// текст перемоги по замовчуванням прихований
						   /// отримуємо кількість елементів з тегом cubes
		countCoub = GameObject.FindGameObjectsWithTag("cubes").Length;
		cubeToWin = countCoub;
		setCount();
	}

	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "cubes")
		{
			Destroy(other.gameObject);
			count++;
			cubeToWin--;
			setCount();
		}
	}
	private void setCount()
	{
		countText.text = " Count :" + count.ToString();
		countToWin.text = " Cube to win :" + cubeToWin.ToString();
		if (count >= countCoub)
			winText.text = " You WIN !!!";
	}
}
