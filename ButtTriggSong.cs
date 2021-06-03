using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtTriggSong : MonoBehaviour
{

  private Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }


  public void Pressed()
  {
      animator.Play("nothing", 0, 0.25f);
      animator.SetBool("nothing", true);
      print("nothing pressed");

      animator.Play("ButtSong", 0, 0.25f);
      animator.SetBool("Pressed", true);

  }

  public void NotPressed()
  {
    animator.SetBool("nothing", false);
    animator.SetBool("Pressed", false);

  }

}
