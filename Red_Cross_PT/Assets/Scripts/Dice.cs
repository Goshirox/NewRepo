using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public int whosTurn = 1;
    private bool coroutineAllowed = true;
    private GameObject reset;
    public string popUp;
    private static GameObject player1, player2;

    private static PopUpSystem popUpSystem;

    public Text diceNumbers;

    public bool playerTurnOne = false;

    public bool playerTurnTwo = false;





    // Use this for initialization
    private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];

        print(whosTurn);

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        popUpSystem = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();

        reset = GameObject.Find("GameControl");

        reset.gameObject.GetComponent<GameControl>();















    }

    public void Update()

    {
        


        print("Player"+ playerTurnOne);


    }



    public void OnMouseDown()
    {
        if (reset.GetComponent<GameControl>().gameOver == false && coroutineAllowed)
        {
            StartCoroutine("RollTheDice");
        }

            


            
    }

    private IEnumerator RollTheDice()
    {

        coroutineAllowed = false;
        int randomDiceSide = 0;

        
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);

            randomDiceSide = randomDiceSide + 1;

            diceNumbers.text = randomDiceSide.ToString();

            

            print("IUYUIYIUIYIU" + randomDiceSide);
        }

        

        //Who's Turn

        GameControl.diceSideThrown = randomDiceSide;
        
        


        if (whosTurn == 1)
        {
            playerTurnOne = true;
            if (popUpSystem.GetComponent<PopUpSystem>().activePopUP == false)
            {
                GameControl.MovePlayer(1);
               
                print("Player One is Moving");

                
                playerTurnTwo = false;
                
            }


            



        } 
        else 
        if (whosTurn == -1)

        {
            playerTurnTwo = true;

            if(popUpSystem.GetComponent<PopUpSystem>().activePopUP == false)
            {
                GameControl.MovePlayer(2);
                print("Player Two is Moving");
                playerTurnOne = false;
                

            }
           
        }

        

        whosTurn *= -1;
        
        coroutineAllowed = true;
    }




    


}
