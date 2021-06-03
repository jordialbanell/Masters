using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtTriggPiano : MonoBehaviour
{

  private Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }

  public void Pressed()
  {
      animator.Play("PianoButt", 0, 0.25f);
      print("piano pressed");
  }

  public void NotPressed()
  {
    print("sup");
   }

}
