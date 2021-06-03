using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTargetSong : MonoBehaviour
{

  int pressed = 0;
  public GameObject videoPlayer;

  [SerializeField] public ButtTriggSong button;

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
      AudioSource source = GetComponent<AudioSource> ();
      source.Play();
      videoPlayer.SetActive(true);

      pressed = 1;
    }

  }




}
