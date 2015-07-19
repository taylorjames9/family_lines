using UnityEngine;
using System.Collections;

public class coin_disappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


  public void  OnTriggerEnter2D(Collider2D other){
    gameObject.SetActive(false);
    switch(other.gameObject.tag){
      case "red_family":
        GameManager.instance.RedTeamMoney += 1000;
        break;

      case "green_family":
        GameManager.instance.BlueTeamMoney += 1000;
        break;

      case "yellow_family":
        GameManager.instance.GreenTeamMoney += 1000;
        break;
 
      case "blue_family":
        GameManager.instance.YellowTeamMoney += 1000;
        break;

      default: 
        break;
   } 
    Destroy(this.gameObject);
  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
