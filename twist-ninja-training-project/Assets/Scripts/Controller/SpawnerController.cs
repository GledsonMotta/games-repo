using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	public float movBallon;
	public float DisInstance;
	private float altura;
	public GameObject objFaseController;
	private RoomFaseController rmController;
	public int contaSpawn =0;
	public bool spwCheese = false;
	public bool spwCheeseAway = false;
	public GameObject prefabCheese;
	public GameObject prefabCheeseGroupOndu;
	public GameController gameController;
	public bool isPlayerBased = false;
	public bool isMoving = false;
	public GameObject objPlayer;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
		rmController = objFaseController.GetComponent<RoomFaseController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doSpawn(GameObject preFab){
		GameObject spawn = preFab;
		
		ISpawnable iPreFab = (ISpawnable)preFab.GetComponent(typeof(ISpawnable));
		
		criaInstancia(iPreFab, spawn);
	}

	void OnTriggerEnter2D(Collider2D outro)	{

		if (contaSpawn < rmController.maxSpawnCount && gameController.vivo) {
			if (outro.tag == "ballons" || outro.tag == "shuriBallon" || outro.tag == "dragon" || outro.tag == "blade" || outro.tag == "bambooGroup") {			

								GameObject spawn = outro.gameObject;
			
								ISpawnable iPreFab = (ISpawnable)outro.gameObject.GetComponent (typeof(ISpawnable));
			
								criaInstancia (iPreFab, spawn);
						}
				}
	}



	private void criaInstancia(ISpawnable iPreFab, GameObject spawn){

		float maxAltura = iPreFab.getMaxAltura ();

		float max = spawn.transform.position.y+maxAltura;
		float min = spawn.transform.position.y-(1f*maxAltura);

		if (isPlayerBased) {
			max = objPlayer.transform.position.y+0.4f;		
			min = objPlayer.transform.position.y-0.4f;
		}

		if(max>1.8f){
			max = 1.8f;
		}
		
		if(min<-2.4f){
			min = -2.4f;
		}


		float distCheese = 0f;

		if (spwCheese) {
			spwCheese = false;
			distCheese=10f*(movBallon/2);
			spawnCheeseGroup(spawn);
		}

	
		contaSpawn++;
		
		altura = Random.Range (max, min);
		
		iPreFab.setMovSpeed(movBallon);

		iPreFab.setMoving (isMoving);

		Instantiate(iPreFab.getPreFab(), new Vector3(spawn.transform.position.x+DisInstance+distCheese, altura, 0), Quaternion.identity);
	}

	private void spawnCheeseGroup(GameObject spawn){
		float altCheese = Random.Range (1f, -1.5f);

		ISpawnable iPreFab = (ISpawnable)prefabCheeseGroupOndu.GetComponent (typeof(ISpawnable));

		iPreFab.setMovSpeed(movBallon);

		Instantiate(iPreFab.getPreFab(), new Vector3(spawn.transform.position.x+DisInstance, altCheese, 0), Quaternion.identity);
	}

	IEnumerator SpawnCheeseAway (GameObject spawn)
	{

		yield return new WaitForSeconds (Random.Range (0.5f, 1f));

		float altCheese = Random.Range (1.8f, -2.5f);
		
		float max = spawn.transform.position.y  -0.8f;
		
		float min = spawn.transform.position.y + 0.8f;

		if(max>1.5f){
			max = 1.8f;
		}
		
		if(min<-2.4f){
			min = -2.4f;
		}

		ISpawnable iPreFab = (ISpawnable)prefabCheese.GetComponent (typeof(ISpawnable));
		
		iPreFab.setMovSpeed(movBallon);
		
		Instantiate(iPreFab.getPreFab(), new Vector3(spawn.transform.position.x+(DisInstance/2), altCheese, 0), Quaternion.identity);
	}
}
