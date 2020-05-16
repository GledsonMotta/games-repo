using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BladeController : MonoBehaviour, ISpawnable {



	public float movBallon;
	public GameObject bladePrefab;
	private float altura;
	public float DisInstance;
	public GameObject prefabCheese;
	public GameController gameController;
	public bool isMoving = false;
	public float gravity = 0.25f;
	private GameObject gobjCheese;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0);

		float altCheese = 0;



		if (!isMoving) {
						if (transform.position.y > 0) {
								altCheese = Random.Range (-0.5f, -2f);		
						} else {
								altCheese = Random.Range (0.5f, 2f);	
						}
				} else {
			altCheese = Random.Range (2f, -2f);	
		}

		gobjCheese = Instantiate(prefabCheese, new Vector3(transform.position.x, altCheese, 0), Quaternion.identity) as GameObject;

		if (isMoving) {		
						GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, 1f);

			gobjCheese.GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, (GetComponent<Rigidbody2D>().velocity.y*2f)*-1f);
				} else {
			gobjCheese.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,0);		
		}
	}

	void Update(){
		GetComponent<Rigidbody2D>().angularVelocity = 1000.0f;

		if (isMoving) {
			if ((transform.position.y > 1.5f && GetComponent<Rigidbody2D>().velocity.y > 0f ) || (transform.position.y < -2.4f && GetComponent<Rigidbody2D>().velocity.y < 0f)) {
				GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y*-1f);				
			}
			if(gobjCheese){
			if ((gobjCheese.transform.position.y > 1.5f && gobjCheese.GetComponent<Rigidbody2D>().velocity.y > 0f ) || (gobjCheese.transform.position.y < -2.4f && gobjCheese.GetComponent<Rigidbody2D>().velocity.y < 0f)) {
				gobjCheese.GetComponent<Rigidbody2D>().velocity = new Vector2 (gobjCheese.GetComponent<Rigidbody2D>().velocity.x, gobjCheese.GetComponent<Rigidbody2D>().velocity.y*-1f);				
				}}
		}
	}


	public GameObject getPreFab(){
		return bladePrefab;
	}

	public void setMovSpeed(float movSpeed){
		movBallon = movSpeed;
	}

	public float getMaxAltura(){
		return 4f;
	}

	public void setMoving(bool isMoving){
		this.isMoving = isMoving;
	}
}
