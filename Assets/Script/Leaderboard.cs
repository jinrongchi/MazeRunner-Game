using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public Transform list;

    public void OnBackBtnClick()
    {
        this.gameObject.SetActive(false);
    }

    public void AddToLeaderboard(string name, string score)
    {
        text.text = name + "                                    " + score;
        GameObject go = Instantiate(text.gameObject);
        go.transform.SetParent(list);
    }
}
