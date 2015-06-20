using UnityEngine;
using System.Collections;

public class Script_Goal : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Ball") {
			Debug.Log ("Win");
		}
	}
}
