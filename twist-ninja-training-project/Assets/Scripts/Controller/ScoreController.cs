using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public Text score;
	public Text scoreCheese;
	public int total = 0;
	public int totalCheese = 0;
	public GameObject cheesePreFab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		score.text = ": " + total;
		scoreCheese.text = ": " + totalCheese;
	}

	public void spawnCheese(float x, float y){
		
		GameObject goCheese = Instantiate(cheesePreFab, new Vector3(x+1f,y,0f), Quaternion.identity) as GameObject;
		goCheese.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
		goCheese.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 2f);
	}

	public void upScore(int value){
		total += value;
	}
}
