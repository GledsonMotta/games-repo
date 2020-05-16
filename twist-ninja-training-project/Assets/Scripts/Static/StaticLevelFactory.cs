using UnityEngine;
using System.Collections;

static class StaticLevelFactory 
{

	public static GameObject preFabBalaoJunto;
	public static GameObject preFabBalaoInvisible;
	public static GameObject preFabBalaoShuriken;
	public static GameObject preFabDragonRed;
	public static GameObject preFabBlade;
	public static GameObject preFabBamboo;
	public static GameObject preFabBalaoJuntoChangeLoop;
	public static GameObject preFabBalaoJuntoDuplicate;
	public static GameObject preFabBalaoJuntoHiding;

	private static int[] arrayMovingLevels = {23,32,44,51,61,70,75,90,94,96};
	private static int[] arrayPlayerBasedLevels = {20,31,42,53,71,82,92};

	/*if (preFabAtual == StaticLevelFactory.getPrefabLevel(1)) {
			preFabAtual = StaticLevelFactory.getPrefabLevel(2);	
			spwController.DisInstance = 2;
			spwController.isPlayerBased=false;
			spwController.movBallon=2;
			maxSpawnCount = 30;
		}else if (preFabAtual == StaticLevelFactory.getPrefabLevel(2)){
			preFabAtual = StaticLevelFactory.getPrefabLevel(3);
			spwController.DisInstance = 5;
			spwController.isPlayerBased=false;
			spwController.movBallon=2;
			maxSpawnCount = 20;
		}
		else if(preFabAtual == StaticLevelFactory.getPrefabLevel(3)){
			preFabAtual = StaticLevelFactory.getPrefabLevel(4);
			spwController.isPlayerBased=true;
			spwController.DisInstance = 3;
			spwController.movBallon=4;
			maxSpawnCount = 30;
		}else if(preFabAtual == StaticLevelFactory.getPrefabLevel(4)){
			preFabAtual = StaticLevelFactory.getPrefabLevel(1);
			spwController.DisInstance = 1;
			spwController.isPlayerBased=false;
			spwController.movBallon=2;
			maxSpawnCount = 30;
		}*/

	public static GameObject getPrefabLevel(int level){


		if (level == 1) {
			return preFabBalaoJunto;		
		}
		/**LEVEL 1**/
		if (level == 10) {
			return preFabBalaoShuriken;		
		}
		if (level == 11) {
			return preFabBalaoJunto;		
		}
		if (level == 12) {
			return preFabBlade;		
		}
		if (level == 13) {
			return preFabBalaoJunto;		
		}

		/**LEVEL 2**/
		if (level == 2) {
			return preFabBalaoShuriken;		
		}

		if (level == 20) {
			return preFabBlade;		
		}
		if (level == 21) {
			return preFabBamboo;		
		}
		if (level == 22) {
			return preFabBalaoJuntoDuplicate;		
		}
		if (level == 23) {
			return preFabBalaoShuriken;		
		}

		/**LEVEL 3**/
		if (level == 3) {
			return preFabDragonRed;		
		}

		if (level == 30) {
			return preFabBalaoJuntoChangeLoop;		
		}
		if (level == 31) {
			return preFabBlade;		
		}
		if (level == 32) {
			return preFabBalaoJunto;		
		}
		if (level == 33) {
			return preFabBamboo;		
		}


		/**LEVEL 4**/
		if (level == 4 || level == 8) {
			return preFabBlade;		
		}

		if (level == 40) {
			return preFabBalaoShuriken;		
		}
		if (level == 41) {
			return preFabBalaoInvisible;		
		}
		if (level == 42) {
			return preFabBlade;		
		}
		if (level == 43) {
			return preFabBalaoJunto;		
		}
		if (level == 44) {
			return preFabBalaoJunto;		
		}

		/**LEVEL 5**/
		if (level == 5) {
			return preFabBalaoJuntoDuplicate;		
		}
		if (level == 50) {
			return preFabDragonRed;		
		}
		if (level == 51) {
			return preFabBamboo;		
		}
		if (level == 52) {
			return preFabBalaoJuntoHiding;		
		}
		if (level == 53) {
			return preFabBlade;		
		}
		if (level == 54) {
			return preFabBalaoJuntoDuplicate;		
		}

		/**LEVEL 6**/
		if (level == 6) {
			return preFabBalaoJuntoChangeLoop;		
		}

		if (level == 60) {
			return preFabBalaoJunto;		
		}
		if (level == 61) {
			return preFabBalaoShuriken;		
		}
		if (level == 62) {
			return preFabBalaoJuntoChangeLoop;		
		}
		if (level == 63) {
			return preFabBalaoInvisible;		
		}
		if (level == 64) {
			return preFabBamboo;		
		}
		if (level == 65) {
			return preFabBalaoJuntoHiding;		
		}

		/**LEVEL 7**/
		if (level == 7) {
			return preFabBamboo;		
		}

		if (level == 70) {
			return preFabDragonRed;		
		}
		if (level == 71) {
			return preFabBlade;		
		}
		if (level == 72) {
			return preFabBalaoShuriken;		
		}
		if (level == 73) {
			return preFabBalaoJunto;		
		}
		if (level == 74) {
			return preFabBalaoShuriken;		
		}
		if (level == 75) {
			return preFabBamboo;		
		}

		/**LEVEL 8**/
		if (level == 9) {
			return preFabBalaoInvisible;		
		}

		if (level == 80) {
			return preFabBalaoJuntoChangeLoop;		
		}
		if (level == 81) {
			return preFabDragonRed;		
		}
		if (level == 82) {
			return preFabBlade;		
		}
		if (level == 83) {
			return preFabBalaoJunto;		
		}
		if (level == 84) {
			return preFabBamboo;		
		}
		if (level == 85) {
			return preFabBalaoInvisible;		
		}

		/**LEVEL 9**/
		if (level == 10) {
			return preFabBalaoJuntoHiding;		
		}

		if (level == 90) {
			return preFabDragonRed;		
		}
		if (level == 91) {
			return preFabBalaoJuntoDuplicate;		
		}
		if (level == 92) {
			return preFabBlade;		
		}
		if (level == 93) {
			return preFabBalaoJuntoChangeLoop;		
		}
		if (level == 94) {
			return preFabBamboo;		
		}
		if (level == 95) {
			return preFabBalaoJuntoHiding;		
		}
		if (level == 96) {
			return preFabBalaoShuriken;		
		}

		/**LEVEL 10**/
		/**EXECUTAR TODOS**/

		/**LEVEL 11**/
		/**LOOP CONTINUO OU RESET**/

		return preFabBalaoJunto;
	}

	public static int getDistanceLevel(int level){
		
		
		/*if (level == 1) {
			return 1;		
		}
		
		if (level == 2) {
			return 2;		
		}
		
		if (level == 3) {
			return 5;		
		}
		
		if (level == 4) {
			return 3;		
		}

		if (level == 5) {
			return 2;		
		}

		if (level == 6) {
			return 1;		
		}

		if (level == 8) {
			return 4;		
		}

		if (level == 1) {
			return 4;		
		}*/

		/**LEVEL 1**/
		if(level<20){
			if (level == 10) {
				return 2;		
			}
			if (level == 11) {
				return 2;		
			}
			if (level == 12) {
				return 4;		
			}
			if (level == 13) {
				return 1;		
			}
		}
		/**LEVEL 2**/
		if(level<30){
			if (level == 20) {
				return 3;		
			}
			if (level == 21) {
				return 2;		
			}
			if (level == 22) {
				return 2;		
			}
			if (level == 23) {
				return 2;		
			}
		}
		/**LEVEL 3**/
		if(level<40){	
			if (level == 30) {
				return 2;		
			}
			if (level == 31) {
				return 3;		
			}
			if (level == 32) {
				return 2;		
			}
			if (level == 33) {
				return 2;		
			}
		}
		
		/**LEVEL 4**/
		if(level<50){
			if (level == 40) {
				return 3;		
			}
			if (level == 41) {
				return 2;		
			}
			if (level == 42) {
				return 3;		
			}
			if (level == 43) {
				return 3;		
			}
			if (level == 44) {
				return 3;		
			}
		}
		
		/**LEVEL 5**/
		if(level<60){
			if (level == 50) {
				return 2;		
			}
			if (level == 51) {
				return 2;		
			}
			if (level == 52) {
				return 2;		
			}
			if (level == 53) {
				return 3;		
			}
			if (level == 54) {
				return 3;		
			}
		}
		
		/**LEVEL 6**/	
		if(level<70){
			if (level == 60) {
				return 3;		
			}
			if (level == 61) {
				return 3;		
			}
			if (level == 62) {
				return 2;		
			}
			if (level == 63) {
				return 3;		
			}
			if (level == 64) {
				return 3;		
			}
			if (level == 65) {
				return 3;		
			}
		}
		
		/**LEVEL 7**/
		if(level<80){
			if (level == 70) {
				return 2;		
			}
			if (level == 71) {
				return 3;		
			}
			if (level == 72) {
				return 4;		
			}
			if (level == 73) {
				return 4;		
			}
			if (level == 74) {
				return 3;		
			}
			if (level == 75) {
				return 3;		
			}
		}
		
		/**LEVEL 8**/
		if(level<90){
			if (level == 80) {
				return 3;		
			}
			if (level == 81) {
				return 3;		
			}
			if (level == 82) {
				return 4;		
			}
			if (level == 83) {
				return 3;		
			}
			if (level == 84) {
				return 4;		
			}
			if (level == 85) {
				return 4;		
			}
		}
		
		/**LEVEL 9**/	
		if(level<100){
			if (level == 90) {
				return 3;		
			}
			if (level == 91) {
				return 3;		
			}
			if (level == 92) {
				return 4;		
			}
			if (level == 93) {
				return 4;		
			}
			if (level == 94) {
				return 4;		
			}
			if (level == 95) {
				return 4;		
			}
			if (level == 96) {
				return 4;		
			}
		}
		
		return 4;
		
		return 2;
	}

	public static int getMovLevel(int level){
		
		/**LEVEL 1**/
		if(level<20){
			if (level == 10) {
				return 2;		
			}
			if (level == 11) {
				return 2;		
			}
			if (level == 12) {
				return 2;		
			}
			if (level == 13) {
				return 2;		
			}
		}
		/**LEVEL 2**/
		if(level<30){
			if (level == 20) {
				return 2;		
			}
			if (level == 21) {
				return 2;		
			}
			if (level == 22) {
				return 2;		
			}
			if (level == 23) {
				return 2;		
			}
		}
		/**LEVEL 3**/
		if(level<40){	
			if (level == 30) {
				return 2;		
			}
			if (level == 31) {
				return 3;		
			}
			if (level == 32) {
				return 2;		
			}
			if (level == 33) {
				return 2;		
			}
		}
		
		/**LEVEL 4**/
		if(level<50){
			if (level == 40) {
				return 3;		
			}
			if (level == 41) {
				return 2;		
			}
			if (level == 42) {
				return 3;		
			}
			if (level == 43) {
				return 3;		
			}
			if (level == 44) {
				return 3;		
			}
		}
		
		/**LEVEL 5**/
		if(level<60){
			if (level == 50) {
				return 2;		
			}
			if (level == 51) {
				return 2;		
			}
			if (level == 52) {
				return 2;		
			}
			if (level == 53) {
				return 3;		
			}
			if (level == 54) {
				return 3;		
			}
		}
		
		/**LEVEL 6**/	
		if(level<70){
			if (level == 60) {
				return 3;		
			}
			if (level == 61) {
				return 3;		
			}
			if (level == 62) {
				return 2;		
			}
			if (level == 63) {
				return 3;		
			}
			if (level == 64) {
				return 3;		
			}
			if (level == 65) {
				return 3;		
			}
		}
		
		/**LEVEL 7**/
		if(level<80){
			if (level == 70) {
				return 2;		
			}
			if (level == 71) {
				return 3;		
			}
			if (level == 72) {
				return 4;		
			}
			if (level == 73) {
				return 4;		
			}
			if (level == 74) {
				return 3;		
			}
			if (level == 75) {
				return 3;		
			}
		}
		
		/**LEVEL 8**/
		if(level<90){
			if (level == 80) {
				return 3;		
			}
			if (level == 81) {
				return 3;		
			}
			if (level == 82) {
				return 4;		
			}
			if (level == 83) {
				return 3;		
			}
			if (level == 84) {
				return 4;		
			}
			if (level == 85) {
				return 4;		
			}
		}
		
		/**LEVEL 9**/	
		if(level<100){
			if (level == 90) {
				return 3;		
			}
			if (level == 91) {
				return 3;		
			}
			if (level == 92) {
				return 4;		
			}
			if (level == 93) {
				return 4;		
			}
			if (level == 94) {
				return 4;		
			}
			if (level == 95) {
				return 4;		
			}
			if (level == 96) {
				return 4;		
			}
		}
		
		return 4;
	}

	public static int getMaxSpawnLevel(int level){
		
		/**LEVEL 1**/
		if(level<20){
		if (level == 10) {
			return 15;		
		}
		if (level == 11) {
			return 15;		
		}
		if (level == 12) {
			return 20;		
		}
		if (level == 13) {
			return 30;		
		}
		}
		/**LEVEL 2**/
		if(level<30){
		if (level == 20) {
			return 20;		
		}
		if (level == 21) {
			return 20;		
		}
		if (level == 22) {
			return 30;		
		}
		if (level == 23) {
			return 20;		
		}
		}
		/**LEVEL 3**/
		if(level<40){	
		if (level == 30) {
			return 20;		
		}
		if (level == 31) {
			return 25;		
		}
		if (level == 32) {
			return 20;		
		}
		if (level == 33) {
			return 30;		
		}
		}
		
		/**LEVEL 4**/
		if(level<50){
		if (level == 40) {
			return 30;		
		}
		if (level == 41) {
			return 30;		
		}
		if (level == 42) {
			return 30;		
		}
		if (level == 43) {
			return 30;		
		}
		if (level == 44) {
			return 30;		
		}
		}
		
		/**LEVEL 5**/
		if(level<60){
		if (level == 50) {
			return 20;		
		}
		if (level == 51) {
			return 30;		
		}
		if (level == 52) {
			return 30;		
		}
		if (level == 53) {
			return 30;		
		}
		if (level == 54) {
			return 30;		
		}
		}
		
		/**LEVEL 6**/	
		if(level<70){
		if (level == 60) {
			return 40;		
		}
		if (level == 61) {
			return 40;		
		}
		if (level == 62) {
			return 40;		
		}
		if (level == 63) {
			return 40;		
		}
		if (level == 64) {
			return 30;		
		}
		if (level == 65) {
			return 40;		
		}
		}
		
		/**LEVEL 7**/
		if(level<80){
		if (level == 70) {
			return 30;		
		}
		if (level == 71) {
			return 40;		
		}
		if (level == 72) {
			return 40;		
		}
		if (level == 73) {
			return 40;		
		}
		if (level == 74) {
			return 40;		
		}
		if (level == 75) {
			return 40;		
		}
		}
		
		/**LEVEL 8**/
		if(level<90){
		if (level == 80) {
			return 40;		
		}
		if (level == 81) {
			return 30;		
		}
		if (level == 82) {
			return 40;		
		}
		if (level == 83) {
			return 40;		
		}
		if (level == 84) {
			return 40;		
		}
		if (level == 85) {
			return 40;		
		}
		}
		
		/**LEVEL 9**/	
		if(level<100){
		if (level == 90) {
			return 40;		
		}
		if (level == 91) {
			return 40;		
		}
		if (level == 92) {
			return 40;		
		}
		if (level == 93) {
			return 40;		
		}
		if (level == 94) {
			return 40;		
		}
		if (level == 95) {
			return 40;		
		}
		if (level == 96) {
			return 40;		
		}
		}

		/**LEVEL 10**/
		/**EXECUTAR TODOS**/
		
		/**LEVEL 11**/
		/**LOOP CONTINUO OU RESET**/
		
		return 40;
	}

	/**Verifica se o spawn deve ser de acordo a posiçao do player**/
	public static bool getPlayerBasedLevel(int level){
				
		return getIsBased(level);
	}

	public static bool getIsMovingLevel(int level){		
		
		return getIsMoving(level);
	}

	public static int getWaitForLevel(int level){

		int wait = 2;

		level++;
		if (level > getMaxLevelForNumber(level)) {
			level=getNextLevelForNumber(level)	;	
		}

		int speedLevel = getMovLevel (level);

		wait = wait*speedLevel;

		return wait;
	}

	public static int getMaxLevelForNumber(int level){

		if(level>=1 && level<=9){
			return 9;
		}

		if(level>=10 && level<=19){
			return 13;
		}
		if(level>=20 && level<=29){
			return 23;
		}
		if(level>=30 && level<=39){
			return 34;
		}
		if(level>=40 && level<=49){
			return 44;
		}
		if(level>=50 && level<=59){
			return 55;
		}
		if(level>=60 && level<=69){
			return 65;
		}
		if(level>=70 && level<=79){
			return 75;
		}
		if(level>=80 && level<=89){
			return 85;
		}
		if(level>=90 && level<=99){
			return 96;
		}
		if(level>=100 && level<=109){
			return 109;
		}

		return 1;
	}

	public static int getNextLevelForNumber(int level){

		if(level==9){
			return 1;
		}

		if(level>=14 && level<=19){
			return 20;
		}
		if(level>=24 && level<=29){
			return 30;
		}
		if(level>=30 && level<=39){
			return 40;
		}
		if(level>=44 && level<=49){
			return 50;
		}
		if(level>=55 && level<=59){
			return 60;
		}
		if(level>=65 && level<=69){
			return 70;
		}
		if(level>=75 && level<=79){
			return 80;
		}
		if(level>=85 && level<=89){
			return 90;
		}
		if(level>=96 && level<=99){
			return 100;
		}
		if(level>=109){
			return 100;
		}

		return 10;
	}

	public static bool getIsMoving(int level){
		foreach(int lv in arrayMovingLevels){
			if(level==lv){
				return true;
			}
		}
		return false;
	}

	public static bool getIsBased(int level){
		foreach(int lv in arrayPlayerBasedLevels){
			if(level==lv){
				return true;
			}
		}
		return false;
	}

	public static int convertLevelBelt(int level){
		if(level<20){
			return 1;
		}
		if(level<30){
			return 2;
		}
		if(level<40){
			return 3;
		}
		if(level<50){
			return 4;
		}
		if(level<60){
			return 5;
		}
		if(level<70){
			return 6;
		}
		if(level<80){
			return 7;
		}
		if(level<90){
			return 8;
		}
		if(level<100){
			return 9;
		}
		if(level<110){
			return 10;
		}
		if (level >= 110) {
			return 11;		
		}
		return 1;
	}
}

