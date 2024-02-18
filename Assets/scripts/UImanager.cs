using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    //variables
   
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;
    private GameManager gameManagerScript;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI numberOfDeathsText;
    

    //funciones

    public void HideWinPanel()
    {
        winPanel.SetActive(false);
    }
    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
        numberOfDeathsText.text = $"Number Of Deaths: {gameManagerScript.deaths} ";

    }
    public void HideGameOverPanel ()
    {
        gameOverPanel.SetActive(false);
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {


        SceneManager.LoadScene("Prototype 1");

    }
    private void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
    }




}
