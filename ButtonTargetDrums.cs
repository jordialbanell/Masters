using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetDrums : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public ButtTriggDrums button;

  void OnMouseDown()
  {

    button.Pressed();
    
    if (pressed == 1)
    {
      AudioSource source = GetComponent<AudioSource> ();
      source.Stop();
      pressed = 0;

    } else if (pressed == 0)
    {
      AudioSource source = GetComponent<AudioSource> ();
      source.Play();
      pressed = 1;
    }

  }




}
