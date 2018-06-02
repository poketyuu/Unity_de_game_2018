using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class EnemyMover : MonoBehaviour {

	// Use this for initialization
	int HP = 3;
	public int limit;
	public GameObject enemybullet;
	private Rigidbody2D e_rigidbody;
	void Start () {
		e_rigidbody = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		e_rigidbody.velocity = new Vector2(-1,Mathf.Sin(100*limit));
		limit--;
		if(limit <= 0){
			GameObject bullet1 = Instantiate(enemybullet,this.transform.position-new Vector3(1,-1,0),Quaternion.identity) as GameObject;
			bullet1.SendMessage("Shot",1);
			GameObject bullet2 = Instantiate(enemybullet,this.transform.position-new Vector3(1,0,0),Quaternion.identity) as GameObject;
			bullet2.SendMessage("Shot",2);
			GameObject bullet3 = Instantiate(enemybullet,this.transform.position-new Vector3(1,+1,0),Quaternion.identity) as GameObject;
			bullet3.SendMessage("Shot",3);
			limit = 50;
		}
	}
	public void Damage(){
		HP--;
		if(HP <= 0){
			Destroy(this.gameObject);
			ScoreContriller.AddPoint();
		}
	}
}
