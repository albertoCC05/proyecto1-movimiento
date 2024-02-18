using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //VARIABLES

    private bool isGameOver = false;
    private float DestructionBound = -10f;
   [SerializeField] private GameObject playerReference;
    private int lives = 3;
    public int deaths = 0;

    private UImanager uiManagerScript;

   //FUNCTIONS
    
    
     private void substractALive()
    {
        if (playerReference.transform.position.y <= DestructionBound)
        {
            lives--;
            deaths++;
            uiManagerScript.livesText.text = $"lives: {lives}";

            playerReference.transform.position = Vector3.zero;
            playerReference.transform.rotation =Quaternion.identity ;
            if (lives <=0)
            {
                isGameOver = true;
                Time.timeScale = 0;
                uiManagerScript.ShowGameOverPanel();
            }
        }
        
    }

    private void Start()
    {
        uiManagerScript = FindObjectOfType<UImanager>();
        uiManagerScript.livesText.text = $"lives: {lives}";
        Time.timeScale = 1;
        uiManagerScript.HideGameOverPanel();
        uiManagerScript.HideWinPanel();
    }

    private void Update()
    {
        substractALive();
    }







}
