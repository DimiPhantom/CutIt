using UnityEngine;
using System.Collections;

public class Script_DragToScreen : MonoBehaviour {
	
	public bool isDrag;
	void Start()
	{
		transform.localPosition=new Vector3(22,86,-2);
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 touchPos = new Vector2 (ray.x, ray.y);
			if (GetComponent<Collider2D> () == Physics2D.OverlapPoint (touchPos)) {
				isDrag = true;
			}
		}
		if (Input.GetMouseButton (0)) {
			if (isDrag) {
				transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			}
		}
		if (Input.GetMouseButtonUp (0)) {
				
			if(transform.position.x<22 || transform.position.x>372 || transform.position.y>303 || transform.position.y<86)
			{
				transform.localPosition=new Vector3(22,86,-2);
			}
			isDrag = false;
		}
	
	}
}
