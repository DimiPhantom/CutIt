using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Menu : MonoBehaviour {

	public Button StartBtn;
	public Button HelpBtn;
	public Button ExitBtn;

	// Use this for initialization
	void Start () {
		StartBtn.onClick.AddListener (delegate {
			Application.LoadLevel ("Stage");
		});
		HelpBtn.onClick.AddListener (delegate {
			Application.LoadLevel ("Help");
		});
		ExitBtn.onClick.AddListener (delegate {
			Application.Quit();
		});
	}

}
