using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class Playerbullet : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D b1_rigidbody;
	void Start () {
		b1_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		b1_rigidbody.velocity = new Vector2(20,0);
		if(this.transform.position.x >= 10){
			Destroy(this.gameObject);
		}
	}
	 /// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "enemy"){
			other.gameObject.SendMessage("Damage");
			Destroy(this.gameObject);
		}
	}
}
