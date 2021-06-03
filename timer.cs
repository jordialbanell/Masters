using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

  public Text timerText;
  static public float finishedTime;
  static public float minutes;
  static public float seconds;
  public float oldminutes;
  public float oldseconds;
  private float startTime;
  public float totalTime;

    // Start is called before the first frame update
    void Start()
    {

      startTime = Time.time;

      oldminutes = minutes;
      oldseconds = seconds;
      print("Finished minutes were " + minutes);
      print("Finished seconds were " + seconds);

      totalTime = finishedTime;

    }

    // Update is called once per frame
    void Update()
    {
      float currentTime = (Time.time - startTime);
      finishedTime = currentTime;

      minutes = ((int) (currentTime+totalTime) / 60);
      seconds = ((currentTime+totalTime) % 60);

      string min = minutes.ToString();
      string sec = seconds.ToString("f1");

      timerText.text = min + ":" + sec;

    }
}
