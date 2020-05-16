using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public bool isBtnPlay = false;
	public bool isBtnExit = false;
	public bool isBtnShop = false;
	public bool isBtnBack = false;
	public bool isBtnSound = false;
	public Sprite[] imgsBtnSound = new Sprite[2];
	public GameController gameController;
	private SpriteRenderer renderer;
	private Image image;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isBtnSound) {
			image = GetComponent<Image> ();
			if(gameController.getSound()>0){
				image.sprite  = imgsBtnSound[1];
			}else{
				image.sprite  = imgsBtnSound[0];
			}
		}	
	}

}
