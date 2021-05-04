using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuWnd : MonoBehaviour
{
    public InputField inputField;

    public void OnStartBtnClick()
    {
        if (inputField.text != null&& inputField.text!="")
        {
            GameManager.Instance.playerName = inputField.text;
            SceneManager.LoadScene("Game");
            GameManager.Instance.gameWnd.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            GameManager.Instance.gameWnd.time = 0;
        }
        else
        {
            inputField.placeholder.GetComponent<Text>().text = "Please Enter Your Name";
        }
      
    }

    public void OnLeaderbordBtnClick()
    {
        GameManager.Instance.Leaderboard.gameObject.SetActive(true);
    }
    public void OnExitBtnClick()
    {
        Application.Quit();
    }
}
