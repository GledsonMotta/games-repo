using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoomFaseController : MonoBehaviour {

	public GameObject[] musicasFundo = new GameObject[2];
	/*public GameObject prefabBalaoJunto;
	public GameObject prefabBalaoShuriken;
	public GameObject prefabDragonRed;
	public GameObject prefabBlade;*/
	public GameObject objSpawner;
	public Image imgHpBar;
	public float hpBar;
	public GameObject objHpBar;
	//public bool vivo;
	private SpawnerController spwController;
	public GameController gameController;
	int musicaAtual;
	public Object objetoMusica;
	public int maxSpawnCount = 0;
	private GameObject preFabAtual;
	private bool ingame = false;
	private bool chamaCheese = false;
	public int level;
	public Text txtBelt;
	public Text txtChapter;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();

		Time.timeScale=gameController.appTime;

		hpBar = 100f;

		gameController.vivo = true;

		level = int.Parse(SecurePlayerPrefs.GetString("nowLevel", "10", "twistninja"));

		level = 30;

		if (gameController.getSound () > 0) {
						musicaAtual = Mathf.FloorToInt (Random.Range (0f, 1.9f));

						objetoMusica = Instantiate (musicasFundo [musicaAtual].GetComponent<AudioSource>(), transform.position, Quaternion.identity);
				}

		spwController = objSpawner.GetComponent<SpawnerController>();

		//preFabAtual = prefabBalaoJunto;

		preFabAtual = StaticLevelFactory.getPrefabLevel(level);	
		spwController.DisInstance = StaticLevelFactory.getDistanceLevel(level);
		spwController.isPlayerBased=StaticLevelFactory.getPlayerBasedLevel(level);
		spwController.movBallon=StaticLevelFactory.getMovLevel(level);
		spwController.isMoving=StaticLevelFactory.getIsMovingLevel(level);
		maxSpawnCount = StaticLevelFactory.getMaxSpawnLevel(level);

		showChapterLevel ();
		playGame ();
	}
	
	// Update is called once per frame
	void Update () {
				if (spwController.contaSpawn >= maxSpawnCount && ingame) {
			ingame = false;
			StartCoroutine(MudaInstanciado());		
		}

		imgHpBar.fillAmount = hpBar / 100f;
		
		if (gameController.vivo == false && Input.GetMouseButtonDown (1)) {
			Time.timeScale=gameController.appTime;
			Application.LoadLevel("SceneFase");
		}
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Time.timeScale=gameController.appTime;
			Application.LoadLevel("SceneMain");
		}
	}
	
	void LateUpdate ()
	{
		if (hpBar <= 0f) {
			gameController.vivo = false;		
		}
	}


	void playGame(){

		if (chamaCheese) {
			spwController.spwCheese = true;

			chamaCheese = false;
		}


		spwController.contaSpawn = 0;

		ingame = true;

		float altura = Random.Range (2.2f, -2.4f);

		preFabAtual.transform.position = new Vector3(8.1f, altura, 0);

		spwController.doSpawn (preFabAtual);

		//Instantiate(prefabBalaoShuriken, new Vector3(10.1f, 0.42f, 0), Quaternion.identity);
	}

	public void btnPauseClick(){
		if (Time.timeScale > 0) {
						Time.timeScale = 0;		
				} else {
			Time.timeScale=gameController.appTime;		
		}
	}

	/**Funçao de Delay StartCoroutine(Example());*/
	IEnumerator BackMusicTimed ()
	{
		
		yield return new WaitForSeconds (300);
		
		DestroyObject (objetoMusica);
		if (gameController.getSound () > 0) {
						objetoMusica = Instantiate (musicasFundo [musicaAtual], transform.position, Quaternion.identity);
				}
	}

	IEnumerator MudaInstanciado ()
	{
//		Debug.Log (StaticLevelFactory.getWaitForLevel(level));


		yield return new WaitForSeconds (StaticLevelFactory.getWaitForLevel(level));

		chamaCheese = true;

		level++;
		if (level > StaticLevelFactory.getMaxLevelForNumber(level)) {
			level=StaticLevelFactory.getNextLevelForNumber(level)	;
			yield return new WaitForSeconds (2);
			showChapterLevel();
		}
		SecurePlayerPrefs.SetString("nowLevel", level.ToString(), "twistninja"); 
		PlayerPrefs.Save();

			preFabAtual = StaticLevelFactory.getPrefabLevel(level);	
		spwController.DisInstance = StaticLevelFactory.getDistanceLevel(level);
		spwController.isPlayerBased=StaticLevelFactory.getPlayerBasedLevel(level);
		spwController.movBallon=StaticLevelFactory.getMovLevel(level);
		spwController.isMoving=StaticLevelFactory.getIsMovingLevel(level);
		maxSpawnCount = StaticLevelFactory.getMaxSpawnLevel(level);

		playGame();
	}

	public void showChapterLevel ()
	{
		int beltLevel = StaticLevelFactory.convertLevelBelt (level);
		txtBelt.text = gameController.lang.getBeltLevel(beltLevel);
		txtChapter.text = gameController.lang.getChapterLabel() + " " + beltLevel.ToString();
		StartCoroutine(hideChapterLevel());
	}

	public void reduzHP ()
	{
		//hpBar -= 25f;
		objHpBar.GetComponent<Animator> ().Play ("CheeseDownAnim");
		verificaHP ();
	}
	
	public void reduzHP (float value)
	{
		//hpBar -= value;
		objHpBar.GetComponent<Animator> ().Play ("CheeseDownAnim");
		verificaHP ();
	}
	
	public void maisHpUp(){
		hpBar +=2f;
		
		if (hpBar > 100f) {
			hpBar = 100f;
		}
		
		objHpBar.GetComponent<Animator> ().Play ("CheeseUpAnim");
	}
	
	private void verificaHP(){
		if (hpBar < 50f && gameController.vivo) {
			if (gameController.getSound() > 0) {
			AudioSource.PlayClipAtPoint (gameController.mouseLaugh, transform.position);
			}
		}
	}

	IEnumerator hideChapterLevel ()
	{
		
		yield return new WaitForSeconds (7);
		
		txtBelt.text = "";
		txtChapter.text = "";
	}
}
