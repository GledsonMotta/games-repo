using UnityEngine;
using System.Collections;

public class DragonController : MonoBehaviour, ISpawnable {

	public GameObject dragonPreFab;
	public float movBallon;
	//private float angulo = 0;
	public bool isMoving;
	public float gravity = 0.25f;
	public GameObject tail;
	public GameObject dragonAtk;


	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0f);
		//Debug.Log("tstaartt");
		if (isMoving) {

						float pos = 0f;

						if (Random.Range (-1f, 1f) >= 0f) {
								pos = -2.4f;
						} else {
								pos = 2f;
						}

						transform.position = new Vector3 (transform.position.x, pos, transform.position.z);

						GetComponent<Rigidbody2D> ().gravityScale = gravity;
				} else {
			//this.GetComponent<Rigidbody2D> ().isKinematic = true;	
			GetComponent<Rigidbody2D> ().gravityScale = 0f;
		}

		StartCoroutine (atkDragon());
	}
	
	// Update is called once per frame
	void Update () {
		if (isMoving) {
						if ((transform.position.y > 0f && GetComponent<Rigidbody2D>().velocity.y > 0f && GetComponent<Rigidbody2D>().gravityScale < 0) || (transform.position.y < -0f && GetComponent<Rigidbody2D>().velocity.y < 0f && GetComponent<Rigidbody2D>().gravityScale > 0)) {
								//rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y*-1f);

								GetComponent<Rigidbody2D>().gravityScale *= -1;

						}
				}

		if (!tail) {
			Destroy(gameObject);
		}
	}

	public GameObject getPreFab(){
		return dragonPreFab;
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

	IEnumerator atkDragon ()
	{
		
		yield return new WaitForSeconds ( Random.Range (1.8f, 2.2f));

		ISpawnable iPreFab = (ISpawnable)dragonAtk.GetComponent (typeof(ISpawnable));
		
		iPreFab.setMovSpeed(movBallon*2);

		Instantiate (iPreFab.getPreFab(), new Vector3(transform.position.x-1.4f,transform.position.y,transform.position.z), Quaternion.identity);

		StartCoroutine (atkDragon());
	}
}
