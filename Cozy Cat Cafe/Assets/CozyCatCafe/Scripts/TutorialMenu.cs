using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    
    public GameObject tutorialPopUp;

    public bool continueToTutorial = false;

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
        SceneManager.LoadScene(3);
    }

    public void Deny()
    {
        tutorialPopUp.SetActive(false);
    }
    
}
