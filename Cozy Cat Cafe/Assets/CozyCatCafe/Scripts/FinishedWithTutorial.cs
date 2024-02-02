using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishedWithTutorial : MonoBehaviour
{
    public Button goToGame;
    private void Awake()
    {
        goToGame.onClick.AddListener(() => Confirm());
    }

    private void Confirm()
    {
        SceneManager.LoadScene(1);
    }
}
