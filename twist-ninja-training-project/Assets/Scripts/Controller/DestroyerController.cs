using UnityEngine;
using System.Collections;

public class DestroyerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D outro)	{
		
		if (outro.tag == "ballons" || outro.tag == "shuriBallon" || outro.tag == "blade" || outro.tag == "bambooGroup" || outro.tag == "bamboo" ||
		    outro.tag == "cheese" || outro.tag == "cheeseGroup" || outro.tag == "dragon" || outro.tag == "dragonAtk") {

			Destroy(outro.gameObject);
		}
	}
}
