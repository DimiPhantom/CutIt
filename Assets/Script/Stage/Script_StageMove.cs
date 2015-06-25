
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StageMove : MonoBehaviour {

	public Button LeftBtn;
	public Button RightBtn;
	public Text StageTxt;
	public static int Stage;
	public static int Level;

	public Button[] StageBtn;
	// Use this for initialization
	void Start () {
		Stage = 1;
		Level = 1;
		for (int i=0; i<10; i++) {
			StageBtn[i].onClick.AddListener(delegate {
				Application.LoadLevel("Game");
			});
		}
		LeftBtn.onClick.AddListener (delegate {
			if (Stage != 1) {
				Stage--;
			}
		});
		RightBtn.onClick.AddListener (delegate {
			if (Stage != 5) {
				Stage++;
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		StageTxt.text = "Level " + Stage.ToString ();
		for (int i=0; i<10; i++) {
			StageBtn [i].GetComponentInChildren<Text> ().text = Stage.ToString () + "-" + (i + 1).ToString ();
		}
	}
}
