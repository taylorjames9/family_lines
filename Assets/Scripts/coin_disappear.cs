using UnityEngine;
using System.Collections;

public class coin_disappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


  public void  OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == "family_dot"){
      Debug.Log("family dot hit coin");
      gameObject.SetActive(false);
    } 
  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
