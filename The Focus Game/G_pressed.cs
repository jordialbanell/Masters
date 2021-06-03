using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_pressed : MonoBehaviour
{
  void OnMouseDown()
  {

    AudioSource source = GetComponent<AudioSource> ();
    source.Play();
    print("GGG");
  }

  void OnMouseUp()
  {

    AudioSource sourcepick = GetComponent<AudioSource> ();
    sourcepick.Stop();
  }
}
