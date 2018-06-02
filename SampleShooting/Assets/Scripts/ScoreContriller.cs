using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContriller : MonoBehaviour {

	// Use this for initialization
	public Text score;
	public static int Score;
	void Start () {
		Score = GetScore();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = ("Score"+Score.ToString());
	}
	public static void AddPoint(){
		Score++;
	}
	public static int GetScore(){
		return Score;
	}
}
