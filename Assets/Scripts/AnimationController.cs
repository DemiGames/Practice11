using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int value;
    void Start()
    {
        animator = GetComponent<Animator>();
        value = Random.Range(0, 3);
    }

    public void ChangeAnimation()
    {
        value = Random.Range(0, 3);
        animator.SetInteger("value",value);
    }
}
