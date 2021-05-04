using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void BtnBack()
    {
        this.gameObject.SetActive(false);
        GameManager.Instance.LoadMenu();
    }
}
