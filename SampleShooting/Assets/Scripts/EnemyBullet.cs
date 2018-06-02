using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D eb_rigidbody;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x <= -10){
			Destroy(this.gameObject);
		}
	}
	public void Shot(int type){
		eb_rigidbody = GetComponent<Rigidbody2D>();
		switch(type){
			case 1:
			eb_rigidbody.velocity = new Vector2(-10,1.5f);
			break;
			case 2:
			eb_rigidbody.velocity = new Vector2(-10,0);
			break;
			case 3:
			eb_rigidbody.velocity = new Vector2(-10,-1.5f);
			break;
			default:
			break;
		}
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player"){
			other.SendMessage("Damage");
			Destroy(this.gameObject);
		}
	}
}
