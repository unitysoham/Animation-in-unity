using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public GameObject npc;
    Animator animator;
    float speed = 1.6f;
    void Start()
    {
        animator = npc.GetComponent<Animator>();
        animator.SetBool("running", true);
       // animator.SetBool("IsIdle", true);
    }


    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}