using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Goal : MonoBehaviour {

	public GameObject Ball;
	public GameObject BallPos;
	public Canvas Result;
	public Button OK;
	public Text Stage;
	public GameObject Maps;
	public GameObject Objects;
	public GameObject ToggleBlock;

	void Start()
	{
		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(true);
		Result.enabled = false;
		OK.onClick.AddListener (NextStage);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Ball" && other.GetComponent<SpriteRenderer>().color==new Color(255, 255, 255, 124)) {
			Result.enabled=true;
		}
	}
	void NextStage()
	{
		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(false);
		EncryptedPlayerPrefs.SetInt (Script_StageMove.Stage+"-"+Script_StageMove.Level,1);
		Script_StageMove.Level++;
		if (Script_StageMove.Level == 11) {
			Script_StageMove.Stage++;
			Script_StageMove.Level = 1;
		}


		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(true);
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		Ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

		Stage.GetComponent<Script_Stage> ().changeStage ();
		foreach (GameObject A in Script_StartButton.prefabs) {
			Destroy (A);
		}
		Objects.SetActive (true);
		Stage.text = "Stage " + Script_StageMove.Stage.ToString() + "-" + Script_StageMove.Level.ToString();
		Result.enabled = false;
	}
}
