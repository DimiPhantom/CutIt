using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Goal : MonoBehaviour {

	public GameObject Ball;
	public Canvas Result;
	public Button OK;
	public Text Stage;
	public GameObject Maps;

	void Start()
	{
		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(true);
		Result.enabled = false;
		OK.onClick.AddListener (NextStage);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Ball") {
			Result.enabled=true;
		}
	}
	void NextStage()
	{
		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(false);
		EncryptedPlayerPrefs.SetInt (Script_StageMove.Stage+"-"+Script_StageMove.Level,1);
		Script_StageMove.Level++;
		if (Script_StageMove.Level == 10) {
			Script_StageMove.Stage++;
			Script_StageMove.Level = 1;
		}
		Maps.transform.FindChild (Script_StageMove.Stage + "-" + Script_StageMove.Level).gameObject.SetActive(true);
		Ball.transform.position = new Vector3 (149, 238, 0);
		Ball.GetComponent<Rigidbody2D> ().gravityScale = 0;
		Ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		foreach (GameObject A in Script_DragButton.prefabs) {
			Destroy (A);
		}
		Stage.text = "Stage " + Script_StageMove.Stage.ToString() + "-" + Script_StageMove.Level.ToString();
		Result.enabled = false;
	}
}
