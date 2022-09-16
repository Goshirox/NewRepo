using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{

    public static MenuScene scene1;

    public SceneManager level;



    private static GameObject Canvas, playerUI;


    public InputField inputfield;
    public InputField inputfield2;
    

    public Text playerName;
    public Text playerName2;

    private void Start()
    {
        Canvas = GameObject.Find("Main Menu");

        playerUI = GameObject.Find("Player_UI");

        playerUI.gameObject.SetActive(false);




    }

   






    public void SetPlayerName()
    {
        playerName.text = inputfield.text;

        playerName2.text = inputfield2.text;

        Canvas.gameObject.SetActive(false);

        playerUI.gameObject.SetActive(true);







        print("CLICKED");
    }



   




}
