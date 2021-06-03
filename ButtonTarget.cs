using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonTarget : MonoBehaviour
{

  int pressed = 0;
  public GameObject videoPlayer;

  [SerializeField] public ButtTrigg button;

  void start()
  {
    videoPlayer.SetActive(false);
  }

  void OnMouseDown()
  {

    videoPlayer.SetActive(false);
    button.Pressed();

    if (pressed == 1)
    {
      AudioSource source = GetComponent<AudioSource> ();
      source.Stop();
      pressed = 0;
      button.NotPressed();
      videoPlayer.SetActive(false);

    } else if (pressed == 0)
    {
      print("playing music");
      AudioSource source = GetComponent<AudioSource> ();
      source.time = 6f;
      source.Play();
      videoPlayer.SetActive(true);

      pressed = 1;
    }

  }




}
