using UnityEngine;
using System.Collections;

public class Script_Drag : MonoBehaviour {

	public bool isDrag;
	public bool isSet;
	public GameObject[] Objects;
	public int cnt;
	public string TargetName;
	void Start()
	{
		Objects = new GameObject[100];
	}
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
			if(transform.position.x<=426 || transform.position.x>=559 || transform.position.y>=303 || transform.position.y<=84)
			{
				if(name=="Circle")
				{
					transform.localPosition=new Vector3(-62, -4.4f,1);
				}
				else if(name=="Rect")
				{
					transform.localPosition=new Vector3(-3,-4.4f,1);
				}
				else if(name=="Tri")
				{
					transform.localPosition=new Vector3(55.3f,-4.4f,1);
				}
			}
			else
			{
				if (isSet) {
					isSet=false;
				}
				else
				{
					GameObject A = (GameObject)Instantiate(Resources.Load (name),transform.position,Quaternion.identity);
					A.GetComponent<Script_Drag>().enabled=false;
					A.tag="Prefab";
				}
				if (name == "Circle") {
					transform.localPosition = new Vector3 (-62, -4.4f, 1);
				}
				else if(name=="Rect")
				{
					transform.localPosition=new Vector3(-3,-4.4f,1);
				}
				else if(name=="Tri")
				{
					transform.localPosition=new Vector3(55.3f,-4.4f,1);
				}
			}
			isDrag = false;
		}
	}
	void OnTriggerStay2D(Collider2D coll)
	{
		isSet = true;
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		isSet = false;
	}
}
