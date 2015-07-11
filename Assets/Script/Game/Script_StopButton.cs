using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StopButton : MonoBehaviour {

	public Button StopButton;
	public GameObject Ball;
	public GameObject BallPos;
	public GameObject Objects;
	public GameObject[] prefabs;
	// Use this for initialization
	void Start () {
		StopButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		prefabs = GameObject.FindGameObjectsWithTag ("Prefab");
		Ball.transform.position = BallPos.transform.position;
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		Ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		Objects.SetActive(true);
		foreach (GameObject A in prefabs) {
			Destroy (A);
			A.GetComponent<Script_Drag>().enabled=false;
		}
	}
}
