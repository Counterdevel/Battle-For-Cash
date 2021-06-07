using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimJumpCaralhudo()
    {
        animator.SetBool("Jump", true);
        StartCoroutine(AcabouPulo(0.5f));
    }

    private IEnumerator AcabouPulo(float tempo)
    {
        yield return new WaitForSeconds(tempo);
        animator.SetBool("Jump", false);
    }
}
