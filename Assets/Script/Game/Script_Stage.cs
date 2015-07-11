using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Stage : MonoBehaviour {
	public Text Stage;
	public GameObject BallPos;
	public GameObject Goal;
	public GameObject Ball;
	// Use this for initialization
	void Start () {//스테이지 설정
		Stage.text = "Stage " + Script_StageMove.Stage.ToString() + "-" + Script_StageMove.Level.ToString();
		changeStage ();
	}
	public void changeStage()
	{
		if (Script_StageMove.Level == 3 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (10, 250, 0);
		} else if (Script_StageMove.Level == 4 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (10, 250, 0);
		} else if (Script_StageMove.Level == 10 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (20, 320, 0);
			Goal.transform.position = new Vector3 (391, 161, 0);
		} else if (Script_StageMove.Level == 5 && Script_StageMove.Stage == 1) {
			Goal.transform.position = new Vector3(395, 277,0);
		}
		else
		{
			Goal.transform.position = new Vector3(386, 72, 0);
			BallPos.transform.position = new Vector3 (149, 238, 0);
		}
		Ball.transform.position = BallPos.transform.position;
	}
}
