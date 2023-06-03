using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


    public class StateMachine : MonoBehaviour
    {
        private int gameLevel;
        private int lifePoints;
        private int score;        // Punktezahl
        private int activeLevel;
        public TMP_Text ScoreText;
        public TMP_Text LifeText;
        [SerializeField] GameObject panel;

        public bool gameIsRunning;
        // Start is called before the first frame update
        void Start()
        {
            panel.gameObject.SetActive(false);
            gameIsRunning = true;
            activeLevel = 1;
            Debug.Log("Statemachine Startet");
            //  Score Start
                    score = 0;
                    lifePoints = 5;
            // Start Punkete bei 0
        }

        // Update is called once per frame
        void Update()
        {
            // Erzeuge neue Werte für Anzeige 
            ScoreText.text = "Score: " + score;
            LifeText.text = "Life: " + lifePoints;
            if(gameIsRunning && lifePoints == 0){
                gameIsRunning = false;
                panel.gameObject.SetActive(true);
            }
        }

        public void AddScore(int points)
        {
            // Punkte werden erhöht um X
            //Debug.Log("Adding Points Treffer");
            score += points;
        }
        public void SubLife(int points)
        {
            // Leben verloren
            //Debug.Log("Leben abziehen");
            if (lifePoints > 0 )
            {
                lifePoints -= points;
            }
            
            
        }

        public void checkNextLevel()
        {

        }

        public void setLevelOneActive()
        {
            
        }


        // Getter Setter
        public int getActiveLevel()
        {
            return activeLevel;
        }
        public bool getGameIsRunning()
        {
            return gameIsRunning;
        }

        public bool getGameIsNOTRunning()
        {
            return !gameIsRunning;
        }
    }   

