using UnityEngine;
using System.Collections;

public class Script_Toggle : MonoBehaviour {

	IEnumerator OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.name == "Ball") {
			yield return new WaitForSeconds (0.1f);
			GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;
		}
	}

}
