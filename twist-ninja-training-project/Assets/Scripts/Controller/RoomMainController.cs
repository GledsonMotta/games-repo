using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoomMainController : MonoBehaviour {

	public GameObject musicaMain;

	public GameController gameController;
	public Object objetoMusica;

	public Text txtPlay;
	public Text txtExit;

	// Use this for initialization
	void Start () {



		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		if (gameController.getSound() > 0) {
						objetoMusica = Instantiate (musicaMain.GetComponent<AudioSource>(), transform.position, Quaternion.identity);
				}

		txtPlay.text = gameController.lang.getBtnPlayLabel();
		txtExit.text = gameController.lang.getBtnExitLabel ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
			Debug.Log ("Terminando Aplicaçao");
		}
	}
	

	public void btnPlayClick(){
			Debug.Log ("Button Play");
			Application.LoadLevel("SceneFase");		

	}

	public void btnExitClick(){
		Debug.Log ("Terminando Aplicaçao");		
		Application.Quit();
	}

	public void btnSoundClick(){
		if (gameController.getSound() > 0) {
						gameController.setSound (0);	
						DestroyObject(objetoMusica);
				} else {
			gameController.setSound(1);	
			objetoMusica = Instantiate (musicaMain.GetComponent<AudioSource>(), transform.position, Quaternion.identity);
		}
	}

	public void btnShopClick(){

	}

	public void btnScoreClick(){

	}

}
