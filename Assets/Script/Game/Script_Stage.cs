using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Stage : MonoBehaviour {
	public Text Stage;
	public GameObject BallPos;
	public GameObject Goal;
	public GameObject Ball;
	public GameObject ToggleButton;
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
		} else if (Script_StageMove.Level == 5 && Script_StageMove.Stage == 1) {
			Goal.transform.position = new Vector3 (370, 130, 0);
		} else if (Script_StageMove.Level == 7 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (18, 287, 0);
			Goal.transform.position = new Vector3 (381, 281, 0);
		} else if (Script_StageMove.Level == 8 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (340, 226, 0);
			Goal.transform.position = new Vector3 (205, 113, 0);
		} else if (Script_StageMove.Level == 9 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (39, 263, 0);
			Goal.transform.position = new Vector3 (203, 78, 0);
		} else if (Script_StageMove.Level == 10 && Script_StageMove.Stage == 1) {
			BallPos.transform.position = new Vector3 (20, 320, 0);
			Goal.transform.position = new Vector3 (381, 168, 0);
		} else if (Script_StageMove.Level == 1 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (151, 174, 0);
			Goal.transform.position = new Vector3 (381, 77, 0);
		} else if (Script_StageMove.Level == 2 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (371, 204, 0);
			Goal.transform.position = new Vector3 (27, 175, 0);
		} else if (Script_StageMove.Level == 3 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (36, 215, 0);
			Goal.transform.position = new Vector3 (383, 95, 0);
		} else if (Script_StageMove.Level == 4 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (36, 150, 0);
			Goal.transform.position = new Vector3 (383, 143, 0);
		} else if (Script_StageMove.Level == 5 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (36, 273, 0);
			Goal.transform.position = new Vector3 (383, 75, 0);
		} else if (Script_StageMove.Level == 6 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (197, 226, 0);
			Goal.transform.position = new Vector3 (198, 295, 0);
		} else if (Script_StageMove.Level == 7 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (66, 160, 0);
			Goal.transform.position = new Vector3 (198, 275, 0);
		} else if (Script_StageMove.Level == 8 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (126, 160, 0);
			Goal.transform.position = new Vector3 (246, 275, 0);
		} else if (Script_StageMove.Level == 9 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (333, 180, 0);
			Goal.transform.position = new Vector3 (162, 130, 0);
		} else if (Script_StageMove.Level == 10 && Script_StageMove.Stage == 2) {
			BallPos.transform.position = new Vector3 (259, 175, 0);
			Goal.transform.position = new Vector3 (29, 194, 0);
		} else if (Script_StageMove.Level == 1 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (150, 175, 0);
			Goal.transform.position = new Vector3 (248, 224, 0);
		} else if (Script_StageMove.Level == 2 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (219, 202, 0);
			Goal.transform.position = new Vector3 (248, 224, 0);
		} else if (Script_StageMove.Level == 3 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (275, 295, 0);
			Goal.transform.position = new Vector3 (90, 78, 0);
		} else if (Script_StageMove.Level == 4 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (244, 127, 0);
			Goal.transform.position = new Vector3 (126, 219, 0);
		} else if (Script_StageMove.Level == 5 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (335, 287, 0);
			Goal.transform.position = new Vector3 (15, 79, 0);
		} else if (Script_StageMove.Level == 6 && Script_StageMove.Stage == 3) {
			BallPos.transform.position = new Vector3 (181, 292, 0);
			Goal.transform.position = new Vector3 (242, 176, 0);
		}
		else
		{
			Goal.transform.position = new Vector3(381, 77, 0);
			BallPos.transform.position = new Vector3 (149, 238, 0);
		}
		Ball.transform.position = BallPos.transform.position;
	}
}
