using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtTrigg : MonoBehaviour
{

  private Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }


  public void Pressed()
  {
      animator.Play("ButtonDown", 0, 0.25f);
      animator.SetBool("Pressed", true);
  }

  public void NotPressed()
  {
    animator.SetBool("Pressed", false);
  }

}
