using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;
    [SerializeField] private Text questionText;
    [SerializeField] List<Button> options;
    

    private Question question;

    
    private bool answer = false;
    
    public bool aCorrect = false;



    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    public void SetQuestion(Question question)
    {
        this.question = question;

        switch(question.questionType)
        {
            case QuestionType.Text:
                 
                
                questionText.transform.parent.gameObject.SetActive(true);

                
            break;

            




        }
        

        questionText.text = question.questionInfo;

       

        for (int i = 0; i < options.Count; i++)
        {
            
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];    
            
        }

        answer = false; 

    
    }

   
    
    

    
}
