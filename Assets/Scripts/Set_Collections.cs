using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Set_Collections : MonoBehaviour {

  public GameObject myCoinPrefab;
  public GameObject myLine;
  private int totalCoins = 20;
  public List<GameObject> family_lines;

	// Use this for initialization
	void Start () {
    foreach(GameObject ln in family_lines){
    
      for(int i=-3;i<totalCoins; i++){
        int rand = Random.Range(2,5); 
        GameObject coin = Instantiate(myCoinPrefab, new Vector2(i*rand, ln.transform.position.y),          Quaternion.identity) as GameObject;
      }  
    }      	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
