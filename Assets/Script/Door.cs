using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Transform Player;
    private bool isOpen = false;
    private Animator animator;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(this.transform.position, Player.position) < 3)
            {
                if (!isOpen)
                {
                    if (GameManager.Instance.gameWnd.GetKeyCount() > 0)
                    {
                        GameManager.Instance.gameWnd.UseKey();
                        animator.SetTrigger("Open");
                        isOpen = true;
                    }
                }
                else
                {
                    animator.SetTrigger("Close");
                    isOpen = false;
                }
            }
        }
    }
}
