using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeMove : MonoBehaviour
{
    public Animator animator;
    public float speed = 0.1f; 
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        if (v==0)
        {
            animator.Play("Idle");
           
        }
        if (v>0)
        {
            animator.Play("Walk");
        }
       


        transform.Rotate(0, speed * 20 * h , 0);       
    }
}
