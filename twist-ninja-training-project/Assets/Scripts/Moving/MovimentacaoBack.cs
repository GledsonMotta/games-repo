using UnityEngine;
using System.Collections;

public class MovimentacaoBack : MonoBehaviour {

	public float movBack;
	public GameObject back;
	public GameObject backWorld;
	public GameController gameController;
	public Sprite[] backgrounds = new Sprite[2];
	private int numBack;


	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		numBack = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (gameController.vivo) {
						GetComponent<Rigidbody2D>().velocity = new Vector2 (-1 * movBack, 0);
						//transform.position -= new Vector3 (movBack * Time.deltaTime, 0, 0);
				} else {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
		}
	}

	void OnTriggerEnter2D(Collider2D outro)
	{

		if (gameObject.tag == "backWorldChange" && outro.tag == "backDestroyer") {

			gameController.fechada *=-1;

			if(gameController.fechada == 1)
			{
			numBack +=1;
			if(numBack>=backgrounds.Length){
				numBack=0;
			}

			backWorld.GetComponent<SpriteRenderer>().sprite = backgrounds[numBack];
			backWorld.transform.position =  new Vector3 (3f, 0, 0);
			}
		}

		if (outro.tag == "backDestroyer") 
		{
			float posicao = 13.1f;
			if(gameController.fechada==1)
			{
				posicao = 16.2f;
			}
			gameObject.transform.position = new Vector3 (posicao,0,0);
		}
	}
}
