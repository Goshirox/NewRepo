using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuitManager : MonoBehaviour
{

    GameObject winCanvas;




    
    

    // Start is called before the first frame update
    void Start()
    {

        winCanvas = GameObject.Find("WinCanvas");

        




    }


    public void Retry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        


    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
        

    }

   



    // Update is called once per frame
    void Update()
    {

       
       
        
    }

     public void OnClick()
    {
        Application.Quit();
    }





}
