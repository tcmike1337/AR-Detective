using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ARDetective {

    public class GameState
    {		
		//Fields
        private enum GS
        {
            StartMenu, OptionMenu, Intro, Investigation, Inventory, Quiz, Outro
        }
        private static int gameState = GS.StartMenu;
        private static List<Clue> foundClues = new List<Clue>();

		//Methods
		public static List<Clue> getClues()
		{
			return List<Clue>(foundClues);
		}
		
		public static void addClue(Clue clue)
		{
			return foundClues.add(clue);
		}

        public static float getClueTotal()
        {
            float totalVal = 0;
            foreach (Clue clue in foundClues) {
                totalVal += clue.weight;
            }
            return totalVal;
        }
		
        public static int getQuizScore()
        {
            return 0;
        }
		
		
    }
}