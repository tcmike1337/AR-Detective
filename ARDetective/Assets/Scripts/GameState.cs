using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ARDetective {

    public class GameState
    {
        private enum GS
        {
            StartMenu, OptionMenu, Intro, Investigation, Inventory, Quiz, Outro
        }
        private static int gameState = (int)GS.StartMenu;

        private static List<Clue> foundClues = new List<Clue>();


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


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


    }

}