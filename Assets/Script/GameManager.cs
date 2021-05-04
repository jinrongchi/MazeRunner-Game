using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public MenuWnd menuWnd;
    public GameWnd gameWnd;
    public PauseWnd pauseWnd;
    public Leaderboard Leaderboard;
    public WinPanel winPanel;

    public string playerName;
   

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        menuWnd.gameObject.SetActive(true);
        gameWnd.gameObject.SetActive(false);
        pauseWnd.gameObject.SetActive(false);
        Leaderboard.gameObject.SetActive(false);
        winPanel.gameObject.SetActive(false);
        SceneManager.LoadScene("Menu");

    }

    public void LoadMenu()
    {
        menuWnd.gameObject.SetActive(true);
        gameWnd.gameObject.SetActive(false);
        pauseWnd.gameObject.SetActive(false);
        Leaderboard.gameObject.SetActive(false);

        SceneManager.LoadScene("Menu");
    }
 
}
