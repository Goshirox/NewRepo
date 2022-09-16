using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public GameControl gameControl;



    private static GameObject 
        whoWinsTextShadow, winCanvas, HighScore, 
        player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public Text displayName;
    public Text displayName2;
    public Text displayName3;




    public static int diceSideThrown = 0;

    //Way Points
    public  int player1StartWaypoint = 0;
    public  int player2StartWaypoint = 0;
    public  int player3StartWaypoint = 0;
    public  int player4StartWaypoint = 0;

    public bool gameOver = false;

    // Use this for initialization
    void Start () 
    
    {

        

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        HighScore = GameObject.Find("HighScore");
        winCanvas = GameObject.Find("WinCanvas");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        











        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        


        
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);


       



        whoWinsTextShadow.gameObject.SetActive(false);

        
}

    // Update is called once per frame
    void Update()
    {

        whoWinsTextShadow.gameObject.SetActive(false);
        HighScore.gameObject.SetActive(false);
        winCanvas.gameObject.SetActive(false);


        //Player One Stops
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)


            





        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
         
            //Reset Movement
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        //Player Two Stops

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)

         
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;

            player1MoveText.gameObject.SetActive(true);
   
            player2MoveText.gameObject.SetActive(false);
           
            //Reset Movement
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        //Player Three Stops

        













        //Who WIns
        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            HighScore.gameObject.SetActive(true);
            whoWinsTextShadow.gameObject.SetActive(true);
            winCanvas.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = displayName.text;
            gameOver = true;
            
        }
        else
        {
           

        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            HighScore.gameObject.SetActive(true);
            whoWinsTextShadow.gameObject.SetActive(true);
            winCanvas.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = displayName2.text;
            gameOver = true;
            
        }
        else
        {
            

        }
















    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) 
        { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;


        }
    }
    

}
