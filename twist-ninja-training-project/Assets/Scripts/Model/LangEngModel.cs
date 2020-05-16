using UnityEngine;
using System.Collections;

public class LangEngModel :ILanguage {

	string[] belts = new string[11];

	public LangEngModel(){

		belts[0] = "White Belt";	
		belts[1] = "Yellow Belt";
		belts[2] = "Green Belt";
		belts[3] = "Purple Belt";
		belts[4] = "Orange Belt";
		belts[5] = "Blue Belt";
		belts[6] = "Brown Belt";
		belts[7] = "Red Belt";
		belts[8] = "Black Belt";
		belts[9] = "Gold Belt";
		belts[10] = "Diamond Belt";
	}

	public string getBeltLevel(int level){
		level--;

		if (level > belts.Length || level < 0) {
			return "Unknown";		
		}

		return belts[level];
	}

	public string getChapterLabel(){
		return "Chapter";
	}

	public string getBtnPlayLabel(){
		return "play";
	}
	
	public string getBtnExitLabel(){
		return "exit";
	}
	
	public string getBtnNewLabel(){
		return "new game";
	}
	
	public string getBtnContinueLabel(){
		return "continue";
	}
}
