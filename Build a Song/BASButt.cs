using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BASButt : MonoBehaviour
{

  private Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }

  public void Pressed()
  {
      animator.Play("BAS Animator", 0, 0.25f);
      //animator.SetBool("Pressed", true);
  }

}
