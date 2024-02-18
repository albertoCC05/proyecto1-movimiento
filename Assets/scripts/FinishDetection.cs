using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDetection : MonoBehaviour
{
    private UImanager uiManagerScript;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            uiManagerScript.ShowWinPanel();
        }

    }
    private void Start()
    {
        uiManagerScript = FindObjectOfType<UImanager>();
       
    }
}
