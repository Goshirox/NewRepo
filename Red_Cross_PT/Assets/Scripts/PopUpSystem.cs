using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public GameObject DangerPop;
    private static GameObject player1, player2;

    
    

    public bool activePopUP = true;

  



    private void Start()
    {
        



        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<CollisionScript>();
        player2.GetComponent<CollisionScript>();

    }
    public void Popup(string text)
    {
        popUpBox.SetActive(true);
        DangerPop.SetActive(false);

        diceimage.SetActive(false);
        popUPText.text = text;
        
        activePopUP = true;
      

        


        





    }

    public void DangerPOP()

    {
        DangerPop.SetActive(true);
        popUpBox.SetActive(false);

       

      


    }

    public void ClosePop()
    {
       
        diceimage.SetActive(true);
     



       
        activePopUP = false;

      






    }
    





    // Start is called before the first frame update
    
}
