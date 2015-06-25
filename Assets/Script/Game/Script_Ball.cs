using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Ball : MonoBehaviour {

	public Button StartButton;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().gravityScale = 0;
		StartButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		GetComponent<Collider2D> ().isTrigger = false;
		GetComponent<Rigidbody2D> ().gravityScale = 10;
	}

}
