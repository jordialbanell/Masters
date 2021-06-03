using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetVocal : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public ButtTrigg button;

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
      source.time = 6f;
      source.Play();
      pressed = 1;
    }

  }




}
