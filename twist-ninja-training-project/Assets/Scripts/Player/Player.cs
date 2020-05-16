using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour
{
		private float angulo = 0;
		public float pulo;
		private bool apertou = false;
		private bool soltou = false;
		public GameObject playerDead;
		public float divisor;
		public ScoreController scoreController;
		public GameController gameController;
		public RoomFaseController roomController;
		public GameObject objRoomFaseController;
		public AudioClip[] swords = new AudioClip[3];
		public AudioClip ballonPop;
		public AudioClip cheeseGet;
		public AudioClip jetFlame;
		public GameObject textoGood;
		public GameObject textoBad;
		public GameObject textoAtual;
		public Canvas cvTexto;
		public GameObject textoAction;
		private string txtAcaoGood;
		private float contaTempo = 0;
		private Animator animTexto;
		private int nrCombo;
		public GameObject objWing;
		private bool jetFlamePlay = false;
		private float speedUp;
		private bool turbo = true;

		// Use this for initialization
		void Start ()
		{
				//scoreController = GameObject.Find ("Main Camera").GetComponent<ScoreController> ();
				gameController = GameObject.Find ("Main Camera").GetComponent<GameController> ();
				roomController = objRoomFaseController.GetComponent<RoomFaseController> ();	
				scoreController = objRoomFaseController.GetComponent<ScoreController> ();
				gameController.vivo = true;
				animTexto = textoAction.GetComponent<Animator> ();
				nrCombo = 0;
				speedUp = pulo;

		}

		// Update is called once per frame
		void Update ()
		{

				if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0)) {
						apertou = true;
						if (turbo) {
								speedUp += 7f * Time.deltaTime;
						}
				} 

				if (Input.GetKeyUp (KeyCode.Space) || Input.GetMouseButtonUp (0)) {
						soltou = true;
				}

				if (GetComponent<Rigidbody2D>().velocity.y < 0) {
						angulo = Mathf.Lerp (10, -60, -GetComponent<Rigidbody2D>().velocity.y / divisor);
				} else if (GetComponent<Rigidbody2D>().velocity.y > 0) {
						angulo = Mathf.Lerp (10, -60, -GetComponent<Rigidbody2D>().velocity.y / divisor);
				} else {
						angulo = 0;		
				}

				transform.eulerAngles = new Vector3 (0, 0, angulo);
				if (contaTempo < 10f) {
						contaTempo = contaTempo + (1f * Time.deltaTime);
				}

				if (contaTempo > 4f && textoAction.GetComponent<Text> ().text != "") {

						textoAction.GetComponent<Text> ().text = "";		
				}

				if (nrCombo <= 5) {
						txtAcaoGood = "";
				} else if (nrCombo > 5 && nrCombo <= 20) {
						txtAcaoGood = "Good!";		
				} else if (nrCombo > 20 && nrCombo <= 50) {
						txtAcaoGood = "Great!";		
				} else if (nrCombo > 50 && nrCombo <= 100) {
						txtAcaoGood = "Wonderful!";		
				} else if (nrCombo > 100) {
						txtAcaoGood = "Unbelievable!";		
				}
		}

		void FixedUpdate ()
		{
				if (soltou) {
						soltou = false;
						apertou = true;
						speedUp = pulo;
				}
				if (apertou && gameController.vivo) {
						GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speedUp);
						apertou = false;
						objWing.GetComponent<Animator> ().Play ("JetHigh");
						if (!jetFlamePlay) {	
								jetFlamePlay = true;
								playSoundJet ();
								StartCoroutine (EsperaSomJet ());
						}
				}
		}

		/**
		 * Metodo para tratar de colisoes com objetos Trigger
		 * */
		void OnTriggerEnter2D (Collider2D outro)
		{			
				if (outro.tag == "redBallon" || outro.tag == "shuriBallon") {

						scoreController.total++;
						nrCombo++;
						/*Destroi Objeto Balao*/
						Destroy (outro.gameObject);
						/*Toca Som Espada*/
						playSoundSword ();
						/*Instancia Texto Açao*/
						exibeTextoGood ();
						exibeAnimAtk ();
						//Instantiate(textoGood, transform.position, Quaternion.identity);
				} else if (outro.tag == "blueBallon") {
						/*Destroi Balao Vitima e reduz HP*/
						roomController.reduzHP ();
						nrCombo = 0;
						Destroy (outro.gameObject);
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();	
						
				} else if (outro.tag == "shuriTrap") {
						/*Destroi Balao Vitima e reduz HP*/
						roomController.reduzHP (10f);
						nrCombo = 0;
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();	
						Destroy (outro.gameObject);
				} else if (outro.tag == "bamboo") {
						/*Destroi Balao Vitima e reduz HP*/
						roomController.reduzHP (20f);
						nrCombo = 0;
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();
				} else if (outro.tag == "blade") {
						/*Destroi Balao Vitima e reduz HP*/
						roomController.reduzHP (25f);
						nrCombo = 0;
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();	
				} else if (outro.tag == "cheese") {
						/*Acrescenta ao Score, Som, e Destroy Cheese*/
						scoreController.totalCheese++;
						roomController.maisHpUp ();
						playSoundCheeseGet ();				
						Destroy (outro.gameObject);
				} else if (outro.tag == "dragon") {
						/*Acrescenta ao Score, Som, e Destroy Cheese*/
						roomController.reduzHP (25f);
						nrCombo = 0;
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();
				} else if (outro.tag == "fire") {
						/*Acrescenta ao Score, Som, e Destroy Cheese*/
						roomController.reduzHP (15f);
						nrCombo = 0;
						Destroy (outro.gameObject);
						playSoundBallonPop ();
						/*Instancia Texto Açao*/
						exibeTextoBad ();
				} else if (outro.tag == "dragonTail") {

						scoreController.upScore (10);
						scoreController.spawnCheese (outro.transform.position.x, outro.transform.position.y);
						nrCombo += 4;

						/*Destroi Objeto Balao*/
						Destroy (outro.gameObject);
						/*Toca Som Espada*/
						playSoundSword ();
						/*Instancia Texto Açao*/
						exibeTextoGood ();
						exibeAnimAtk ();
				}

		}

		void playSoundSword ()
		{
				if (gameController.getSound () > 0) {
						int mus = Mathf.FloorToInt (Random.Range (0f, 2.9f));								
						AudioSource.PlayClipAtPoint (swords [mus], transform.position);
				}
		}

		void playSoundBallonPop ()
		{
				if (gameController.getSound () > 0) {											
						AudioSource.PlayClipAtPoint (ballonPop, transform.position);
				}
		}

		void playSoundCheeseGet ()
		{
				if (gameController.getSound () > 0) {											
						AudioSource.PlayClipAtPoint (cheeseGet, transform.position);
				}
		}

		void playSoundJet ()
		{
				if (gameController.getSound () > 0) {											
						AudioSource.PlayClipAtPoint (jetFlame, transform.position, 0.8f);
				}
		}

		/**
	 	* Metodo para tratar de colisoes com objetos solidos nao Trigger
	 	* */
		/*void OnCollisionEnter2D (Collision2D outro)
		{
			if (outro.gameObject.tag == "objTeto") {	
			}
		}*/

		void exibeTextoGood ()
		{


				textoAction.GetComponent<Text> ().color = Color.green;

				textoAction.GetComponent<Text> ().text = "x" + nrCombo + " " + txtAcaoGood;

				contaTempo = 0f;

				animTexto.Play ("TextActionAnim");

				/*if (textoAtual) {
			DestroyObject(textoAtual);		
		}
		textoAtual.transform.SetParent( cvTexto.transform );

		textoAtual = Instantiate (textoGood, new Vector3(100,-100,0), Quaternion.identity) as GameObject;*/

				//textoAtual.transform.SetParent( cvTexto.transform );
		}

		void exibeTextoBad ()
		{

				textoAction.GetComponent<Text> ().color = Color.red;
		
				textoAction.GetComponent<Text> ().text = "Bad!";

				contaTempo = 0f;

				//	Animator anim = textoAction.GetComponent<Animator> ();

				animTexto.Play ("TextActionAnim");
		}

		void exibeAnimAtk ()
		{
				GetComponent<Animator> ().Play ("TwistFlyNrAtkAnim");
		}

		/**Funçao de Delay StartCoroutine(Example());*/
		IEnumerator Example ()
		{
				print (Time.time);
				yield return new WaitForSeconds (5);
				print (Time.time);
				gameController.vivo = true;
		}

		IEnumerator LimpaTexto ()
		{
			
				yield return new WaitForSeconds (2);
				textoAction.GetComponent<Text> ().text = "";
		}

		IEnumerator EsperaSomJet ()
		{
				yield return new WaitForSeconds ((jetFlame.length - (jetFlame.length * 0.2f)));
				jetFlamePlay = false;				
		}
}
