using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private static GameObject player1, player2;



    public bool IsActive;

    public bool IsPop;

    public string popUp;


    public bool P1QuestionCollison = false;

    public bool P2QuestionCollison = false;

    public bool P1DangerCollision = false;  

    public bool P2DangerCollision = false;
    

    
    // Start is called before the first frame update
    void Start()
    {

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>();
        player2.GetComponent<FollowThePath>();
    }

    // Update is called once per frame
    void Update()
    {
         if (GetComponent<FollowThePath>().moveAllowed == false)
        {
            IsActive = false;
            print(IsActive);
        }

        if (GetComponent<FollowThePath>().moveAllowed == true)
        {
            IsActive = true;
            IsPop = false;
            print(IsActive);
        }

        

        
       

    }

    public void OnTriggerStay(Collider localCollider)

    
    {
        GameObject localOtherObject;
        localOtherObject = localCollider.gameObject;

        

        if(localOtherObject.name.StartsWith("Neutral"))
        {
            


            if (!IsActive && !IsPop)
            {
                PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();

                pop.Popup(popUp);

                print("Landed on DangerPaw");

                IsPop = true;

                
                print(IsActive);
              
            }

        }

        if (localOtherObject.name.StartsWith("DangerPaw"))
        {
            if (!IsActive && !IsPop)
            {
                PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();

                pop.DangerPOP();

                print("Landed on DangerPaw");
                IsPop = true;

                P1DangerCollision = true;

                P1QuestionCollison = false;



                print("Collsion Danger");



                print(IsActive);
            }

        }

        if (localOtherObject.name.StartsWith("QuestionPaw"))
        {
            if (!IsActive && !IsPop)
            {
                PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();

                pop.Popup(popUp);

                print("Landed on QuestionPaw");
                IsPop = true;


                P1QuestionCollison = true;

                P1DangerCollision = false;

                print("Collsion Question");





                print(IsActive);


            }

            
            

        }



        






    }
}
