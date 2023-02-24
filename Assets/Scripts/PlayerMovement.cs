using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    Animator animator;
    float horizontalinput;
    float forwardinput;
    float speed = 1.1f; 
       void Start()
    {
        animator = player.GetComponent<Animator>();
        animator.SetBool("IsRunning", true);
    }

    
    void Update()
    {
        
        transform.Translate(Vector3.forward * speed *  Time.deltaTime);
    }
}
