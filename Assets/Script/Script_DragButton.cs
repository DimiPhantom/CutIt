using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_DragButton : MonoBehaviour {

	public static GameObject[] prefabs;
	public Button DragButton;
	void Start()
	{
		DragButton.onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		prefabs = GameObject.FindGameObjectsWithTag ("Prefab");
		foreach (GameObject Prefabs in prefabs) {
			Prefabs.GetComponent<Script_DragToScreen>().enabled=true;
		}
	}
}
