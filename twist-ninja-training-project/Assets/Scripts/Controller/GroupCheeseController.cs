using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GroupCheeseController : MonoBehaviour, ISpawnable {


//	private SpriteRenderer renderer;
	public float movBallon;
	private bool isDrop;
	private float posYStart;
	public GameController gameController;

	// Use this for initialization
	void Start () {

		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0);
	}

	void Update(){
		if (!gameController.vivo) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
		}
	}

	public GameObject getPreFab(){
		return gameObject;
	}
	
	public void setMovSpeed(float movSpeed){
		movBallon = movSpeed;
	}
	
	public float getMaxAltura(){
		return 1.2f;
	}

	public void setMoving(bool isMoving){}
}
