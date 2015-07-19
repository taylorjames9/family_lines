using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

  private float yellowTeamMoney;
  private float greenTeamMoney;
  private float blueTeamMoney;
  private float redTeamMoney;
  public string flus = "flus";

  private string flum = "flum";
  public string Flum{
  get{ return flum; }set{}
  } 
  
  public float RedTeamMoney{
    get{
      return redTeamMoney;
    }
    set {
      redTeamMoney = value;
    }
  } 
  public float YellowTeamMoney {
    get{
      return yellowTeamMoney;
    }
    set {
      yellowTeamMoney = value;
    }
  } 
  public float BlueTeamMoney{
    get{
      return blueTeamMoney;
    }
    set {
      blueTeamMoney = value;
    }
  } 
  public float GreenTeamMoney{
    get{
      return greenTeamMoney;
    }
    set {
      greenTeamMoney = value;
    }
  } 

private static GameManager _instance;
public static GameManager instance{
  get {
    if(_instance == null)
      _instance = GameObject.FindObjectOfType<GameManager>();
    return _instance;
  }

}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
