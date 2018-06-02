using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySponer : MonoBehaviour {

	// Use this for initialization
	public int spon1 = 100;
	public int spon2 = 50;
	public int change = 0;
	private int spend = 0;
	public GameObject enemy;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		spend++;
		if(change < 10){
			if(spend >= spon1){
				Instantiate(enemy,new Vector2(12,Random.Range(-5,5)),Quaternion.identity);
				change++;
				spend=0;
			}
		}else{
			if(spend >= spon2){
				Instantiate(enemy,new Vector2(12,Random.Range(-5,5)),Quaternion.identity);
				spend = 0;
			}
		}
	}
}
