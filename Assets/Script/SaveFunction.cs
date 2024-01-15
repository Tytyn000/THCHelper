using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFunction : MonoBehaviour
{
    public GameObject QuitButton;
    public ReadInputField ReadInputField;
    public CopyScript CopyScript;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (QuitButton.activeSelf == false)
            {
                QuitButton.SetActive(true);
                Time.timeScale = 0.0f;
            }
            else if (QuitButton.activeSelf == true)
            {
                QuitButton.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
        else if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand)) && Input.GetKeyDown(KeyCode.S))
        {
            ReadInputField.SaveCurrentData();
        }
        else if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand)) && Input.GetKeyDown(KeyCode.Q))
        {
            QuitApplicationWithoutSaving();
        }
        else if (Input.GetKey(KeyCode.F12))
        {
            CopyScript.CopyToClipboard();
        }
        else if (Input.GetKeyDown(KeyCode.F1))
        {
            CopyScript.CopyHit1Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            CopyScript.CopyHit2Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            CopyScript.CopyHit3Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F4))
        {
            CopyScript.CopyHit4Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F5))
        {
            CopyScript.CopyHit5Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F6))
        {
            CopyScript.CopyHit6Damage();
        }
        else if (Input.GetKeyDown(KeyCode.F7))
        {
            CopyScript.CopyHit7Damage();
        }
    }
    public void ClickOnBackGroundOfQuitButton()
    {
        Time.timeScale = 1.0f;
        QuitButton.SetActive(false);
    }
    public void QuitApplicationWithSaving()
    {
        Time.timeScale = 1.0f;
        ReadInputField.SaveCurrentData();
        Application.Quit();
    }
    public void QuitApplicationWithoutSaving()
    {
        Time.timeScale = 1.0f;
        Application.Quit();
    }
}
