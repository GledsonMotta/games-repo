using UnityEngine;
using System.Collections;

public class BackWorldController : MonoBehaviour {
	public GameController gameController;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

			if (gameController.vivo) {
				transform.position -= new Vector3 (0.2f * Time.deltaTime, 0, 0);
			}
	
	}
}
