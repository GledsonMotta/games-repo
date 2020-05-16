using UnityEngine;

interface ISpawnable {

	// Use this for initialization
	GameObject getPreFab ();

	void setMovSpeed(float movSpeed);

	float getMaxAltura();

	void setMoving(bool isMoving);
}
