using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWnd : MonoBehaviour
{
    public void OnContinueBtnClick()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }

    public void OnMenuButtonClick()
    {
        GameManager.Instance.LoadMenu();
        Time.timeScale = 1;
    }
    public void OnLeaderbordBtnClick()
    {
        GameManager.Instance.Leaderboard.gameObject.SetActive(true);
    }
}
