using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StopButton : MonoBehaviour {

	public Button StopButton;
	public GameObject Ball;
	// Use this for initialization
	void Start () {
		StopButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		Ball.transform.position = new Vector3 (149, 238, 0);
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		Ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		foreach (GameObject A in Script_DragButton.prefabs) {
			Destroy (A);
		}
	}
}
