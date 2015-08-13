using UnityEngine;
using System.Collections;

public class Script_Ball : MonoBehaviour {

	public GameObject BallPos;
	public GameObject Objects;
	public GameObject BlackHole;
	public ParticleSystem Broken;
	public GameObject[] ToggleBlock;
	void Start()
	{
		Broken.Stop ();
	}
	IEnumerator OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.name == "Sword") {
			Broken.transform.position = this.transform.position;
			Broken.Play ();
			yield return new WaitForSeconds (0.1f);
			Broken.Stop ();
			GetComponent<Rigidbody2D> ().gravityScale = 0;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			transform.position = BallPos.transform.position;
			Objects.SetActive (true);
			ToggleBlock = GameObject.FindGameObjectsWithTag ("ToggleBlock");
			foreach (GameObject A in ToggleBlock) {
				A.GetComponent<SpriteRenderer> ().enabled = true;
				A.GetComponent<BoxCollider2D> ().enabled = true;
				A.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			}
			foreach (GameObject A in Script_StartButton.prefabs) {
				Destroy (A);
			}
		}
		if (other.collider.name.Length>5 && other.collider.name.Substring (0, 5) == "White") {
			if(GetComponent<SpriteRenderer>().color!=new Color(0,0,0,255))
			{
				GetComponent<SpriteRenderer>().color=new Color(0, 0, 0, 255);
			}
			else
			{
				GetComponent<SpriteRenderer>().color=new Color(255, 255, 255, 124);
			}
		}
	}
}
