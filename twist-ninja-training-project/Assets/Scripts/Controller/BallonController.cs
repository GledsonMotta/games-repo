 using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallonController : MonoBehaviour {

	public Sprite[] ballons = new Sprite[8];
	public Sprite[] bads = new Sprite[4];
	public Sprite[] ballonsI = new Sprite[8];
	public Sprite[] badsI = new Sprite[4];
	private SpriteRenderer renderer;
	public float movBallon;
	public bool isChanging;
	private bool changeState;
	public int maxCountChange;
	private float countChange=0;
	private int maxStateCountChange;
	public float ySpeed;
	public bool isDuplicate;
	public bool isHiding;
	public bool isInvisible;
	public float maxDupMove;
	private int sprBallon=0;

	// Use this for initialization
	void Start () {
		changeState = false;
		maxStateCountChange = maxCountChange;
		if (gameObject.tag == "blueBallon" && !isDuplicate) {
						
						sprBallon = Mathf.FloorToInt (Random.Range (0f, 7.9f));
		
						renderer = GetComponent<SpriteRenderer> ();

						renderer.sprite = ballons [sprBallon];
		} else if (gameObject.tag == "redBallon" || gameObject.tag == "shuriBallon"||isDuplicate) {
			sprBallon = Mathf.FloorToInt (Random.Range (0f, 3.9f));
			
						renderer = GetComponent<SpriteRenderer> ();
			
			renderer.sprite = bads [sprBallon];
				}

		if (gameObject.tag == "shuriBallon") {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-1*movBallon, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.parent.position.x);
		if (isDuplicate) {
			if(transform.position.x<=3f){

				GetComponent<Rigidbody2D>().velocity=new Vector2(transform.parent.GetComponent<Rigidbody2D>().velocity.x,ySpeed);

				isDuplicate=false;
			}		
		}


		if ((transform.position.y-transform.parent.position.y >= maxDupMove && GetComponent<Rigidbody2D>().velocity.y > 0f) || (transform.position.y-transform.parent.position.y <= maxDupMove && GetComponent<Rigidbody2D>().velocity.y < 0f)) {
			GetComponent<Rigidbody2D>().velocity=new Vector2(GetComponent<Rigidbody2D>().velocity.x,0f);		

		}

		if (isInvisible) {
			if(transform.position.x<=3.5f){
					isInvisible=false;
				if (gameObject.tag == "blueBallon") {

					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = ballonsI [sprBallon];
				} else if (gameObject.tag == "redBallon") {

					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = badsI [sprBallon];
				}
			}
				}

		if (isChanging) {
			countChange=countChange+(1f*Time.deltaTime);
			if(countChange>=maxStateCountChange){
				countChange=0f;
				if (changeState) {
					changeState = false;
					sprBallon = Mathf.FloorToInt (Random.Range (0f, 7.9f));
					
					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = ballons [sprBallon];

					maxStateCountChange=maxCountChange;
				} else {
					changeState = true;
					sprBallon = Mathf.FloorToInt (Random.Range (0f, 3.9f));
					
					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = bads [sprBallon];
					maxStateCountChange=maxCountChange*2;
				}			}		
		}

		if (isHiding) {
			countChange=countChange+(1f*Time.deltaTime);
			if(countChange>=maxStateCountChange){
				countChange=0f;
				if (!changeState) {
					changeState = true;
					sprBallon = Mathf.FloorToInt (Random.Range (0f, 7.9f));
					
					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = ballons [sprBallon];
					
					maxStateCountChange=maxCountChange*2;
				} else {
					changeState = false;
					sprBallon = Mathf.FloorToInt (Random.Range (0f, 3.9f));
					
					renderer = GetComponent<SpriteRenderer> ();
					
					renderer.sprite = bads [sprBallon];
					maxStateCountChange=maxCountChange;
				}			}		
		}

	}
}
