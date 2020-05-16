using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{


		
		/*public float hpBar;
		public Image imgHpBar;*/
		//public GameObject objHpBar;
		public float posicaoAtual;
		public AudioClip music;
		public bool vivo;
		public AudioSource musicss;
		public GameObject musicaFundo;
		public GameObject musicaFundo2;
		public Object objetoMusica;
		public int fechada = -1;
		public AudioClip mouseLaugh;

	public GameObject prefabBalaoJunto;
	public GameObject prefabBalaoShuriken;
	public GameObject prefabDragonRed;
	public GameObject prefabBlade;
	public GameObject prefabBalaoJuntoChangeLoop;
	public GameObject prefabBalaoJuntoDuplicate;
	public GameObject prefabBamboo;
	public GameObject prefabBalaoInvisible;
	public GameObject prefabBalaoJuntoHiding;
	public ILanguage lang;
	private int stSound;
	public float appTime;

		// Use this for initialization
		void Start ()
		{
		StaticLevelFactory.preFabBalaoJunto = prefabBalaoJunto;
		StaticLevelFactory.preFabBalaoShuriken = prefabBalaoShuriken;
		StaticLevelFactory.preFabBlade = prefabBlade;
		StaticLevelFactory.preFabDragonRed = prefabDragonRed;
		StaticLevelFactory.preFabBalaoJuntoChangeLoop = prefabBalaoJuntoChangeLoop;
		StaticLevelFactory.preFabBalaoJuntoDuplicate = prefabBalaoJuntoDuplicate;
		StaticLevelFactory.preFabBamboo = prefabBamboo;
		StaticLevelFactory.preFabBalaoInvisible = prefabBalaoInvisible;
		StaticLevelFactory.preFabBalaoJuntoHiding = prefabBalaoJuntoHiding;

		appTime = Time.timeScale;

		if (Application.systemLanguage == SystemLanguage.Portuguese) {
			lang = new LangPtModel ();
				} else {
						lang = new LangEngModel ();
				}

		vivo = true;
			
		stSound = int.Parse(SecurePlayerPrefs.GetString("stSound", "1", "twistninja"));

		}
		
		// Update is called once per frame
		void Update ()
		{
			
		}

		void LateUpdate ()
		{
				
		}

		
	public ILanguage getLang(){
		return lang;
	}

	public void setSound(int volume){
		stSound = volume;
		SecurePlayerPrefs.SetString("stSound", stSound.ToString(), "twistninja"); 
		PlayerPrefs.Save();
	}

	public int getSound(){
		return stSound;
	}
}
