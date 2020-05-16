using UnityEngine;
using System.Collections;

public class LangPtModel :ILanguage {

	string[] belts = new string[11];

	public LangPtModel(){

		belts[0] = "Faixa Branca";	
		belts[1] = "Faixa Amarela";
		belts[2] = "Faixa Verde";
		belts[3] = "Faixa Roxa";
		belts[4] = "Faixa Laranja";
		belts[5] = "Faixa Azul";
		belts[6] = "Faixa Marrom";
		belts[7] = "Faixa Vermelha";
		belts[8] = "Faixa Preta";
		belts[9] = "Faixa Ouro";
		belts[10] = "Faixa Diamante";
	}

	public string getBeltLevel(int level){
		level--;

		if (level > belts.Length || level < 0) {
			return "Desconhecido";		
		}

		return belts[level];
	}

	public string getChapterLabel(){
		return "Capitulo";
	}

	public string getBtnPlayLabel(){
		return "jogar";
	}
	
	public string getBtnExitLabel(){
		return "sair";
	}
	
	public string getBtnNewLabel(){
		return "novo jogo";
	}
	
	public string getBtnContinueLabel(){
		return "continuar";
	}
}
