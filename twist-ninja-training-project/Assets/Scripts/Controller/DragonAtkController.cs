using UnityEngine;
using System.Collections;

public class DragonAtkController : MonoBehaviour, ISpawnable {

	public GameObject dragonAtkPreFab;
	public GameObject dragonFirePreFab;
	public float movBallon;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0f);

		//dragonFirePreFab.transform.parent = gameObject.transform;

		GameObject obj = Instantiate (dragonFirePreFab, transform.position, Quaternion.identity) as GameObject;

		obj.transform.parent = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public GameObject getPreFab(){
		return dragonAtkPreFab;
	}
	
	public void setMovSpeed(float movSpeed){
		movBallon = movSpeed;
	}
	
	public float getMaxAltura(){
		return 1.2f;
	}
	

	public void setMoving(bool isMoving){

	}
}
