using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class FinDelJuego : MonoBehaviour
{
    public bool GameIsFinished = false;
    public GameObject EndMenuUI;
    public Text titleText;
    public Text scoreText;

    // Update is called once per frame
    public void ShowPanel(int score, bool victoria)
    {
        EndMenuUI.SetActive(true);
        Time.timeScale = 0f;
        if (victoria)
        {
            titleText.text = "Has ganado";
        }
        else
        {
            titleText.text = "Has perdido";
        }
        scoreText.text = score.ToString();
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
