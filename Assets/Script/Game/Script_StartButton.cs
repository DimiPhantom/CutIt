using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StartButton : MonoBehaviour {

	public Button StartButton;
	public static GameObject[] prefabs;
	public GameObject Ball;
	public GameObject Objects;
	// Use this for initialization
	void Start () {
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		StartButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		prefabs = GameObject.FindGameObjectsWithTag ("Prefab");
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 10;
		Ball.GetComponent<Collider2D> ().isTrigger = false;
		Objects.SetActive(false);
		foreach (GameObject A in prefabs) {
			A.GetComponent<Script_Drag>().enabled=false;
			A.GetComponent<Collider2D> ().isTrigger = false;
			A.GetComponent<Rigidbody2D>().gravityScale=20;
			A.GetComponent<Rigidbody2D>().angularDrag=0.6f;
			A.GetComponent<Rigidbody2D>().drag=0.5f;
		}
	}
}
