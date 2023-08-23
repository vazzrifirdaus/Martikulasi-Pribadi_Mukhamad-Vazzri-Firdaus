using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("PinBall_Game");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
