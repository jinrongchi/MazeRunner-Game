using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWnd : MonoBehaviour
{
    [SerializeField]
    private Text txtTime;
    [SerializeField]
    private Text txtkeyCount;
    private int keyCount = 0;
    public float time = 0;
    private bool isPause=false;
    private void Awake()
    {
        time = 0;
    }
    private void Update()
    {
        time += Time.deltaTime;
        txtTime.text = ((int)time).ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause==false)
            {
                isPause = true;
                Time.timeScale = 0;
                GameManager.Instance.pauseWnd.gameObject.SetActive(true);
            }
            else

            {
                isPause = false;
                Time.timeScale = 1;
                GameManager.Instance.pauseWnd.gameObject.SetActive(false);
            }
        }
    }
    public void PickUpKey()
    {
        keyCount++;
        txtkeyCount.text = "Key:" + keyCount;
    }
    public void UseKey()
    {
        keyCount--;
        txtkeyCount.text = "Key:" + keyCount;
    }

    public int GetKeyCount()
    {
        return keyCount;
    }
}
