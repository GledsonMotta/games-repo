using UnityEngine;
using System.Collections;

public class ActTextController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Example());

	}
	
	// Update is called once per frame
	void Update () {

		//transform.position -= new Vector3 (transform.position.x,-0.2f,transform.position.z);
	}

	/**Funçao de Delay StartCoroutine(Example());*/
	IEnumerator Example ()	{
		yield return new WaitForSeconds (2);
		Destroy (gameObject);
	}
}
