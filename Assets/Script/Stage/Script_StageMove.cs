using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StageMove : MonoBehaviour {

	public Button LeftBtn;
	public Button RightBtn;
	public Text StageTxt;
	public static int Stage=3;
	public static int Level=1;
	public int[] EnabledButton;

	public Button[] StageBtn;

	void Start () {

		for (int i=1; i<=5; i++) {
			for (int j=1; j<=10; j++) {
				EnabledButton[(i-1)*10+j-1]=EncryptedPlayerPrefs.GetInt (i + "-" + j, 0);
			}
		}
		EnabledButton [0] = 1;

		for (int i=0; i<10; i++) {
			int tmp=i;
			StageBtn[i].onClick.AddListener(()=>{StartGame(tmp);});
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
	void StartGame(int param)
	{
		Level = param + 1;
		Application.LoadLevel("Game");
	}
	void Update () {
		StageTxt.text = "Level " + Stage.ToString ();
		for (int i=0; i<10; i++) {
			if(EnabledButton[(Stage-1)*10+i]==0)
			{
				StageBtn[i].interactable=false;
			}
			else
			{
				StageBtn[i].interactable=true;
			}
			StageBtn [i].GetComponentInChildren<Text> ().text = Stage.ToString () + "-" + (i + 1).ToString ();
		}
	}
}
