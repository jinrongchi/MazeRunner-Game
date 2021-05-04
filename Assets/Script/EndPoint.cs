using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            GameManager.Instance.Leaderboard.AddToLeaderboard(GameManager.Instance.playerName, GameManager.Instance.gameWnd.time.ToString("0.00"));
            GameManager.Instance.winPanel.gameObject.SetActive(true);
        }
    }
}
