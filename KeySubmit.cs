using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySubmit : MonoBehaviour
{

  private int pressed;
  //private Animator animator;

  [SerializeField] public MusicNotesCode SubmitKeys;

    public void OnMouseDown()
    {
      // animator.Play("SubmitKeys", 0, 0.1f);
      print ("pressed count " + pressed);
      pressed += 1;

      if (pressed == 1) {
        SubmitKeys.Check(1);

      } else if (pressed == 2) {
        SubmitKeys.Check(2);
        pressed = 0;
      }
  }


}
