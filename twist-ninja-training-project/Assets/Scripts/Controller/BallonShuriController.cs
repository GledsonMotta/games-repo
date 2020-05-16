using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallonShuriController : MonoBehaviour, ISpawnable {

	public Sprite[] ballons = new Sprite[8];
	public Sprite[] bads = new Sprite[4];
	private SpriteRenderer renderer;
	public float movBallon;
	public GameObject shuriBallonPrefab;
	public GameObject objShuriken;
	private float altura;
	public float DisInstance;
	public bool isMoving;
	private float[] altera = new float[2];
	public GameController gameController;

	// Use this for initialization
	void Start () {
		altera[0] = 1.0f;
		altera[1] = -1.0f;
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		if (gameObject.tag == "redBallon" || gameObject.tag == "shuriBallon") {
						int spr = Mathf.FloorToInt (Random.Range (0f, 3.9f));
			
						renderer = GetComponent<SpriteRenderer> ();
			
						renderer.sprite = bads [spr];
				}

		if (gameObject.tag == "shuriBallon") {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0);
		}

		if (isMoving) {		
			int spd = Mathf.FloorToInt (Random.Range (-1.9f, 1.9f));

			float speed=0f;
			speed=spd>0?1f:-1f;
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, speed);
		}

		//float shuriSpeed = Random.Range (2f,4f);
	
		int modif = Mathf.FloorToInt (Random.Range (0f, 1.9f));

		float taxa = Random.Range (0.7f, 1.7f);

		/*if (isMoving) {
			taxa = Random.Range (1.7f, 2.7f);	
		}*/

		objShuriken.transform.Rotate(new Vector3 (0, 0, Mathf.FloorToInt (Random.Range (0f, 300f))));
		objShuriken.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
		objShuriken.GetComponent<Rigidbody2D>().angularVelocity = 100.0f*(altera[modif])*taxa;
	}

	void FixedUpdate(){
		if (!gameController.vivo) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
			if(objShuriken!=null){
				objShuriken.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity;}
			}	
		if (isMoving) {
			if ((transform.position.y > 1.5f && GetComponent<Rigidbody2D>().velocity.y > 0f ) || (transform.position.y < -2.4f && GetComponent<Rigidbody2D>().velocity.y < 0f)) {
				GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y*-1f);	
				if(objShuriken!=null){
					objShuriken.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity;}
			}
		}
	}


	public GameObject getPreFab(){
		return shuriBallonPrefab;
	}

	public void setMovSpeed(float movSpeed){
		movBallon = movSpeed;
	}

	public float getMaxAltura(){
		return 1.8f;
	}

	public void setMoving(bool isMoving){
		this.isMoving = isMoving;
	}
}
