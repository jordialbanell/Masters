using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtTriggDrums : MonoBehaviour
{

  private Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }

  public void Pressed()
  {
      animator.Play("DrumButt", 0, 0.25f);
      //animator.SetBool("appear", true);
    //  print("drum pressed");
  }

  public void NotPressed()
  {
    print("sup");


   }

}
