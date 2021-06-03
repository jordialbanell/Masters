using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetFocuslvl2 : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public ButtTriggSonglvl2 button;


  void OnMouseDown()
  {
    print("hello");
    button.Pressed();

  }

}
