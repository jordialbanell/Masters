using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2bcube : MonoBehaviour
{

    public void playMelody(){

      AudioSource source = GetComponent<AudioSource> ();
      source.Play();
    }
}
