using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_pressed : MonoBehaviour
{
  void OnMouseDown()
  {

    AudioSource source = GetComponent<AudioSource> ();
    source.Play();
  }

  void OnMouseUp()
  {

    AudioSource sourcepick = GetComponent<AudioSource> ();
    sourcepick.Stop();
  }
}
