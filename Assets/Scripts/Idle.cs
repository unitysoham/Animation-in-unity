using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    public GameObject npc;
    Animator animator;
   
    void Start()
    {
        animator = npc.GetComponent<Animator>();
        animator.SetBool("IsIdle", true);

    }

   
    void Update()
    {
        
    }
}
