using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour
{

  public Transform theDest;
  public Transform plankCheck;
  public int count = 0;

  public Vector3 MyVocalPosition;
  public Vector3 MyVSpedPosition;
  public Vector3 MyVSlowPosition;


  public float groundDistance = 1f;
  public LayerMask groundMask;

  bool isPlank;

  void Update() {

    MyVocalPosition = GameObject.Find("Vocal").transform.position;
    MyVSpedPosition = GameObject.Find("Vocal Sped").transform.position;
    MyVSlowPosition = GameObject.Find("Vocal Slow").transform.position;
    isPlank = Physics.CheckSphere(plankCheck.position, groundDistance, groundMask);

  }

  public void playVocals()
  {
      Invoke ("actuallyPlay", 6);

  }

  public IEnumerator soundOn()
  {
    yield return new WaitForSeconds(3f);
    AudioSource source = GetComponent<AudioSource> ();
    source.Play();
  }

  public IEnumerator soundOff()
  {
    yield return new WaitForSeconds(6f);
    AudioSource source = GetComponent<AudioSource> ();
    source.Stop();
  }

  public void playVocalsRight()
  {
    soundOn();
    soundOff();
  }

  public void playVocalsBad()
  {
    soundOn();
    soundOff();
  }

  public void actuallyPlay()
  {
    print("trying to play vocal");
    AudioSource source = GetComponent<AudioSource> ();
    source.Play();
  }

  public void stopVocals()
  {
    AudioSource sourcegood = GetComponent<AudioSource> ();
    sourcegood.Stop();
  }

  public int checkifVocPlank()
  {
    if ((MyVocalPosition[0] <= 363.5 && MyVocalPosition[0] >= 362.5) &&
    (MyVocalPosition[1] <= .9 && MyVocalPosition[1] >= 0.5) &&
    (MyVocalPosition[2] <= 111 && MyVocalPosition[2] >= 109))
    {
      return (1);

      } else if ((MyVSpedPosition[0] <= 363.5 && MyVSpedPosition[0] >= 362.5) &&
      (MyVSpedPosition[1] <= 0.9 && MyVSpedPosition[1] >= 0.5) &&
      (MyVSpedPosition[2] <= 111 && MyVSpedPosition[2] >= 109))
      {
        return (2);

        } else if ((MyVSlowPosition[0] <= 363.5 && MyVSlowPosition[0] >= 362.5) &&
        (MyVSlowPosition[1] <= 0.9 && MyVSlowPosition[1] >= 0.5) &&
        (MyVSlowPosition[2] <= 111 && MyVSlowPosition[2] >= 109))
        {
          return(3);

        } else if (MyVSlowPosition[1] > 3 || MyVocalPosition[1] > 3 || MyVSpedPosition[1] >3 )
        {
          return(5);
        }
        return (0);
      }

      public void playButtVocals()
      {
        AudioSource source = GetComponent<AudioSource> ();
        source.time = 6f;
        source.Play();
      }

      void OnMouseDown()
      {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

        AudioSource sourcepick = GetComponent<AudioSource> ();
        sourcepick.time = 6f;
        sourcepick.Play();
      }

      void OnMouseUp()
      {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;

        AudioSource sourcepick = GetComponent<AudioSource> ();
        sourcepick.Stop();
      }

    }
