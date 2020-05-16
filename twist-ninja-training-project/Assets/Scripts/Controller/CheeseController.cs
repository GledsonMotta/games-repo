using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheeseController : MonoBehaviour, ISpawnable {


//	private SpriteRenderer renderer;
	public float movBallon;
	private bool isDrop;
	private float posYStart;

	// Use this for initialization
	void Start () {

		posYStart = transform.position.y-Random.Range(0.3f,1f);
	}

	void Update(){
		if (GetComponent<Rigidbody2D>().gravityScale > 0f && transform.position.y<posYStart) {
			GetComponent<Rigidbody2D>().gravityScale = 0f;
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0);
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
