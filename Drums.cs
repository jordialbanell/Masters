using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drums : MonoBehaviour
{

  public Transform theDest;
  public Transform plankCheck;
  public int count = 0;

  public Vector3 MyDrumsPosition;
  public Vector3 MyDFalse1Position;
  public Vector3 MyDFalse2Position;

  public float groundDistance = 1f;
  public LayerMask groundMask;

  bool isPlank;

  void Update() {

    MyDrumsPosition = GameObject.Find("Drums").transform.position;
    MyDFalse1Position = GameObject.Find("Drum Sped").transform.position;
    MyDFalse2Position = GameObject.Find("Drum Slow").transform.position;

    isPlank = Physics.CheckSphere(plankCheck.position, groundDistance, groundMask);
  }

  public void playDrums()
  {
      print("drums");
      AudioSource source = GetComponent<AudioSource> ();
      source.Play();

  }

  public void playDrumsRight()
  {
    Invoke ("playDrums", 3);
  }

  public void playDrumsBad()
  {
    Invoke ("playDrums", 6);
  }

  public int checkifDruPlank()
  {
    print("checking drums");
    print(MyDrumsPosition[0] + " " + MyDrumsPosition[1] + " " + MyDrumsPosition[2]);

    if ((MyDrumsPosition[0] <= 363.5 && MyDrumsPosition[0] >= 362.5) &
    (MyDrumsPosition[1] <= .9 && MyDrumsPosition[1] >= .5) &
    (MyDrumsPosition[2] <= 114 && MyDrumsPosition[2] >= 112))
    {
      return (1);
      print("what");

      } else if ((MyDFalse1Position[0] <= 363.5 && MyDFalse1Position[0] >= 362.5) &&
      (MyDFalse1Position[1] <= .9 && MyDFalse1Position[1] >= .5) &&
      (MyDFalse1Position[2] <= 114 && MyDFalse1Position[2] >= 112))
      {
        return (2);

        } else if ((MyDFalse2Position[0] <= 363.5 && MyDFalse2Position[0] >= 362.5) &&
        (MyDFalse2Position[1] <= .9 && MyDFalse2Position[1] >= .5) &&
        (MyDFalse2Position[2] <= 114 && MyDFalse2Position[2] >= 112))
        {
          return(3);

          } else if (MyDFalse2Position[1] > 3 || MyDrumsPosition[1] > 3 || MyDFalse1Position[1] >3 )
          {
            return(5);
          }
        return (0);
      }

  public void stopDrums()
  {
    AudioSource sourcegood = GetComponent<AudioSource> ();
    sourcegood.Stop();
  }

  void OnMouseDown()
  {
    GetComponent<Rigidbody>().useGravity = false;
    GetComponent<Rigidbody>().freezeRotation = true;
    this.transform.position = theDest.position;
    this.transform.parent = GameObject.Find("Destination").transform;

    print("playing drums");
    AudioSource drumsound = GetComponent<AudioSource> ();
    drumsound.Play();
  }

  void OnMouseUp()
  {
    this.transform.parent = null;
    GetComponent<Rigidbody>().useGravity = true;
    GetComponent<Rigidbody>().freezeRotation = false;
    AudioSource drumsound = GetComponent<AudioSource> ();
    drumsound.Stop();
  }

}
