using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetFocus : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public ButtTriggFocus button;


  void OnMouseDown()
  {
    print("hello");
    button.Pressed();

    // if (pressed == 1)
    // {
    //     AudioSource source = GetComponent<AudioSource> ();
    //     source.Stop();
    //     pressed = 0;
    //     button.NotPressed();
    //
    //
    // } else if (pressed == 0)
    // {
      playmusic();
      pressed = 1;

  }

  public void playmusic()
  {
    AudioSource source = GetComponent<AudioSource> ();
    source.Play();
  }




}
