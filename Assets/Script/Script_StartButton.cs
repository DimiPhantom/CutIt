using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StartButton : MonoBehaviour {

	public Button StartButton;
	public GameObject Ball;
	// Use this for initialization
	void Start () {
		StartButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 10;
		foreach (GameObject A in Script_DragButton.prefabs) {
			A.GetComponent<Collider2D> ().isTrigger = false;
			A.GetComponent<Rigidbody2D>().gravityScale=20;
			A.GetComponent<Rigidbody2D>().angularDrag=0.6f;
			A.GetComponent<Rigidbody2D>().drag=0.5f;
			A.GetComponent<Script_DragToScreen>().enabled=false;
		}
	}
}
