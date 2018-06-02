using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D p_rigidbody;
	public int HP = 5;
	private int speed = 10;
	private int interval = 0;
	public GameObject bullet;
	public string nextScene;
	void Start () {
		p_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		interval++;
		if(Input.GetKey(KeyCode.RightArrow)){
			p_rigidbody.velocity = new Vector2(speed,0);
		}else if(Input.GetKey(KeyCode.LeftArrow)){
			p_rigidbody.velocity = new Vector2(-speed,0);
		}else if(Input.GetKey(KeyCode.UpArrow)){
			p_rigidbody.velocity = new Vector2(0,speed);
		}else if(Input.GetKey(KeyCode.DownArrow)){
			p_rigidbody.velocity = new Vector2(0,-speed);
		}else{
			p_rigidbody.velocity = new Vector2(0,0);
		}
		if(Input.GetKey(KeyCode.Space)){
			if(interval > 20){
				interval = 0;
				Instantiate(bullet,this.transform.position + new Vector3(1,0,0),Quaternion.identity);
			}
		}
	}
	public void Damage(){
		HP--;
		if(HP <= 0){
			SceneManager.LoadScene(nextScene);
		}
	}
}
