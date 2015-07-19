using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIDisplayManager : MonoBehaviour {

  public Text redText;
  public Text greenText;
  public Text yellowText;
  public Text blueText;
  private GameManager gm;

	// Use this for initialization
	void Start () {
    gm = GetComponent<GameManager>();	
    Debug.Log("the value of flus = "+gm.flus);
    Debug.Log("the value of flum = "+gm.Flum);
	}
	
	// Update is called once per frame
	void Update () {
	 redText.text = gm.RedTeamMoney.ToString();
	 greenText.text = gm.GreenTeamMoney.ToString();
	 yellowText.text = gm.YellowTeamMoney.ToString();
	 blueText.text = gm.BlueTeamMoney.ToString();
	}
}
