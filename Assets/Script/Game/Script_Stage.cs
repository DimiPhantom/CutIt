using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Stage : MonoBehaviour {
	public Text Stage;
	// Use this for initialization
	void Start () {
		Stage.text = "Stage " + Script_StageMove.Stage.ToString() + "-" + Script_StageMove.Level.ToString();
	}
}
