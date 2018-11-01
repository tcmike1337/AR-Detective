using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizQuestion : MonoBehaviour {

    public void Start()
    {
        // read answers and questions into arrays where each element is a line in the file
        string[] answersFile = System.IO.File.ReadAllLines(@"/Users/reiddelbello/Projects/KohaiKhaos/AR-Detective.git/trunk/ARDetective/Sample_Answers.txt");
        string[] questionsFile = System.IO.File.ReadAllLines(@"/Users/reiddelbello/Projects/KohaiKhaos/AR-Detective.git/trunk/ARDetective/Sample_Questions.txt");

        int amountQuestions = 8;   // var holds the total number of questions we're creating
        int answersFileIdx;        // var holds index into the answersFile array
        Question[] AllQuestions = new Question[amountQuestions];   // array of class QzQuestion holds 8 questions with answers

        for (int i = 0; i < amountQuestions; i++)     // build amount of questions entered
        {
            Question currentQ = new Question();
            currentQ.questionStr = questionsFile[i];
            currentQ.answers = new Answer[4];
            answersFileIdx = i * 8;         // 0,8,16... each question is 8 lines of answerFile
            for (int j = 0; j < 4; j++)
            {
                Answer ans = new Answer();      // create answer struct
                ans.answerString = answersFile[answersFileIdx];     // add line from file to ans property
                ans.rating = float.Parse(answersFile[answersFileIdx + 1]);  // next line holds the rating
                answersFileIdx += 2;    // go to next answer and rating
                currentQ.answers[j] = ans;   // save the answer to the array of the current question
            }

            AllQuestions[i] = currentQ;
        }

        foreach (Question q in AllQuestions)
        {
            print(q.ToString());
        }
    }

    //private static string question { get; set; }
    //// Four possible answer choices
    //private static Answer[] answers;
    
    public struct Question
    {
        public string questionStr { get; set; }
        public Answer[] answers { get; set; }

        public override string ToString()
        {
            string str;
            str = questionStr;
            foreach (Answer ans in answers)
            {
                str += "\n";
                str += ans.answerString + "    " + ans.rating;
            }
            return str;
        }
    }

    public struct Answer
    {
        public string answerString { get; set;}
        public float rating { get; set;}   // rating based on selection
    }
	// Update is called once per frame
	void Update () {
		
	}
}
