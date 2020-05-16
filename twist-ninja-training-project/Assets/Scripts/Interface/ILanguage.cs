using UnityEngine;

public interface ILanguage {

	// Use this for initialization
	string getBeltLevel (int l);

	string getChapterLabel();

	string getBtnPlayLabel();

	string getBtnExitLabel();

	string getBtnNewLabel();

	string getBtnContinueLabel();
}
