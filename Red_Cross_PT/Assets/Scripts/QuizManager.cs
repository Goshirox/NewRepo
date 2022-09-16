using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public static QuizManager quiz;
    
    [SerializeField] private QuizUI memberQuizUI;
    [SerializeField] private List<Question> memberQuestions;

    private static Dice playerturns;

    private static CollisionScript collided1, collided2;


    public Question correctAnswerPoint;

    public static GameObject danger;


    public Text [] scoreText;
    

    public int[] score = {6, 6};

    

    public bool playerOne = false;

    public bool playerTwo = false;

    public bool aCorrect = false;

    public bool correctAnswer = false;

    

    






    private Question memberSelectedQuestion;


    // Start is called before the first frame update
    void Start()
    {

        playerturns = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();

        collided1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<CollisionScript>();

        collided2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<CollisionScript>();








        SelectQuestion();
        scoreText[0].text = score[0].ToString();
        scoreText[1].text = score[1].ToString();

        danger = GameObject.Find("DangerManager");

        danger.gameObject.GetComponent<QuizManager>();

        danger.gameObject.GetComponent<QuizManager>().score = score;


    }

    void SelectQuestion()
    {
        int localValue = Random.Range(0,memberQuestions.Count);
        memberSelectedQuestion = memberQuestions[localValue];
        memberQuizUI.SetQuestion(memberSelectedQuestion);

    }



    public void Update()
    {

        print("correct" + correctAnswer);

        






        if (playerturns.GetComponent<Dice>().playerTurnOne == true)
        {

            

            if (correctAnswer)
            {

                if (collided1.GetComponent<CollisionScript>().P1DangerCollision == true)

                {
                    score[2] += memberSelectedQuestion.correctAnswerPoint;
                   





                    scoreText[2].text = score[2].ToString();

                    correctAnswer = false;

                }



                
                if (collided1.GetComponent<CollisionScript>().P1QuestionCollison == true)
                {

                    score[0] += memberSelectedQuestion.correctAnswerPoint;
                    






                    scoreText[0].text = score[0].ToString();

                    correctAnswer = false;



                }

                



















            }
            else
            {


            }



            









        }

        if (playerturns.GetComponent<Dice>().playerTurnTwo == true)
        {
            if (correctAnswer)
            {



                if (collided2.GetComponent<CollisionScript>().P1DangerCollision == true)

                {
                    score[3] += memberSelectedQuestion.correctAnswerPoint;
                    





                    scoreText[3].text = score[3].ToString();

                    correctAnswer = false;

                }








                
                if (collided2.GetComponent<CollisionScript>().P1QuestionCollison == true)
                {

                    score[1] += memberSelectedQuestion.correctAnswerPoint;

                    











                    correctAnswer = false;



                }

              















            }

            else
            {

            }



            

            


        }

        
        
 




    }

    public bool Answer(string localanswered)
    {
        

        
        correctAnswer = false;
       
        
        if (localanswered == memberSelectedQuestion.correctAnswer)
        {
            
            
            correctAnswer = true;

            

            

           
            
        }

        else
        {
            

        }

       
        
        Invoke("SelectQuestion");

        return correctAnswer;

        

    }

    


    public void AddPoint(int playerPoint)
    {
        switch (playerPoint)
        {
            case 1:
                score[0] += memberSelectedQuestion.correctAnswerPoint;
                scoreText[0].text = score[0].ToString();
                break;

            case 2:
                score[1] += memberSelectedQuestion.correctAnswerPoint;
                scoreText[1].text = score[1].ToString();
                break;

                 


        }

        

        
        

        
        
    }

    public void PlayerTurn(int playerTurns)
    {
        switch (playerTurns)
        {
            case 1:
                playerturns.GetComponent<Dice>().playerTurnOne = true;
                break;

            case 2:
                playerturns.GetComponent<Dice>().playerTurnTwo = true;
                break;
                 
                    



        }



    }






}


[System.Serializable]
public class Question
{
    public string questionInfo;
    public List<string> options;
    public string correctAnswer;
    public int correctAnswerPoint;
    public Text questionType;


}







