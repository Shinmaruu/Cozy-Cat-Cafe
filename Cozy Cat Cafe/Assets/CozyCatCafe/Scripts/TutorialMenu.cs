using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    // Meant to power the buttons for the "Would you like to play the tutorial" options
    
    public GameObject tutorialPopUp;

    public static TutorialMenu instance;


    private void Awake()
    {
        if (instance == null || instance != this)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Confirm()
    {
        // go to Tutorial Scene
        SceneManager.LoadScene(3);
    }

    public void Deny()
    {
        //turn off the popup
        tutorialPopUp.SetActive(false);
        // go to Base Game
        SceneManager.LoadScene(1);
    }
    
}
