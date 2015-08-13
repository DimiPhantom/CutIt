using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StopButton : MonoBehaviour {

	public Button StopButton;
	public GameObject Ball;
	public GameObject BallPos;
	public GameObject Objects;
	public GameObject Map;
	public GameObject[] ToggleBlock;
	// Use this for initialization
	void Start () {
		StopButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		Ball.transform.position = BallPos.transform.position;
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		Ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		Ball.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255, 124);
		Objects.SetActive(true);
		foreach (GameObject A in Script_StartButton.prefabs) {
			Destroy (A);
		}
		ToggleBlock = GameObject.FindGameObjectsWithTag ("ToggleBlock");
		foreach (GameObject A in ToggleBlock) {
			A.GetComponent<SpriteRenderer>().enabled=true;
			A.GetComponent<BoxCollider2D>().enabled=true;
			A.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
		}
	}
}
