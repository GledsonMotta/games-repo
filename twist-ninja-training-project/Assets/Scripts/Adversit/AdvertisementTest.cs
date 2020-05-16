using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdvertisementTest : MonoBehaviour {

	/*AdMob: ID do bloco de anúncios: ca-app-pub-6933995828367310/5363703181*/

	void Awake() {
		/*if (Advertisement.isSupported) {
			Advertisement.allowPrecache = true;
			Advertisement.Initialize ("131622678",true);
		} else {
			Debug.Log("Platform not supported");
		}*/
	}
	
	void OnGUI() {
		/*if(GUI.Button(new Rect(10, 10, 150, 50), Advertisement.isReady() ? "Show Ad" : "Waiting...")) {
			// Show with default zone, pause engine and print result to debug log
			Advertisement.Show(null, new ShowOptions {
				pause = false,
				resultCallback = result => {
					Debug.Log(result.ToString());
				}
			});
		}*/
	}
}