using UnityEngine;
using System.Collections;

public class Script_Drag : MonoBehaviour {

	public bool isDrag;
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector3 ray;
			ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
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
			if(isDrag)
			{
				if(name.Contains("Clone"))
				{
					if(transform.position.x>422.2f && transform.position.y<83.6f)
					{
						Destroy (this.gameObject);
					}
				}
				else
				{
					if(transform.position.x>422.2f && transform.position.y<83.6f)
					{
						PositionChange();
					}
					else
					{
						GameObject A = (GameObject)Instantiate(Resources.Load (name),transform.position,Quaternion.identity);
						A.tag="Prefab";
						PositionChange();
					}
				}
			}
			isDrag = false;
		}
	}
	void PositionChange()
	{
		if (name == "Circle") {
			transform.localPosition = new Vector3 (-62, -4.4f, 1);
		} else if (name == "Rect") {
			transform.localPosition = new Vector3 (-3, -4.4f, 1);
		} else if (name == "Tri") {
			transform.localPosition = new Vector3 (56, -4.4f, 1);
		}
	}
}
