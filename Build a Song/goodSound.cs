using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodSound : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public SubmitButt button;


  void OnMouseDown()
  {

    button.Pressed();
  }
}
