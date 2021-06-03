using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BASPress : MonoBehaviour
{

  int pressed = 0;

  [SerializeField] public BASButt button;

  void OnMouseDown()
  {
    print("hello?"); 
    button.Pressed();

  }

}
