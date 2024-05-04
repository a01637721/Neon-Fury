using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_p1 : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("p1_anim");
        Destroy(gameObject, 0.5f);
    }

}