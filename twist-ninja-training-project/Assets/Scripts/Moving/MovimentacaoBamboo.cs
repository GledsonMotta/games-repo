using UnityEngine;
using System.Collections;

public class MovimentacaoBamboo : MonoBehaviour, ISpawnable {

	public float movBallon;
	public GameObject Bamboo;
	public float DisInstance;
	private float altura;
	public bool isMoving;
	public GameController gameController;


	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0f);

		if (isMoving) {		
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, 1f);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!gameController.vivo) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
		}
		if (isMoving) {
			if ((transform.position.y > 1.5f && GetComponent<Rigidbody2D>().velocity.y > 0f ) || (transform.position.y < -2.4f && GetComponent<Rigidbody2D>().velocity.y < 0f)) {
				GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y*-1f);				
			}
		}
	}


	public GameObject getPreFab(){
		return Bamboo;
	}

	public void setMovSpeed(float movSpeed){
		movBallon = movSpeed;
	}

	public float getMaxAltura(){
		if (isMoving) {
			return 0.2f;		
		}



		return 0.8f;
	}

	public void setMoving(bool isMoving){
		this.isMoving = isMoving;
	}
}
