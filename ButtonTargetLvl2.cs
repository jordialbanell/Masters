using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetLvl2 : MonoBehaviour
{

  public GameObject drums;
  public GameObject vocal;
  public GameObject actualDrums;

  Vocal vocal_script;
  Drums drums_script;
  ButtTriggDrums drumsGo;

  int pressed = 0;

  [SerializeField] public ButtTriggDrums button;

  void Start()
  {
    vocal_script = vocal.GetComponent<Vocal>();
    drums_script = drums.GetComponent<Drums>();
  }

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
