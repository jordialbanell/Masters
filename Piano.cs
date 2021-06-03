using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{

    public Transform theDest;
    public Transform plankCheck;
    public int count = 0;

    public Vector3 MyPianoPosition;
    public Vector3 MyPFalse1Position;
    public Vector3 MyPFalse2Position;

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isPlank;

    void Update() {

      MyPianoPosition = GameObject.Find("Piano").transform.position;
      MyPFalse1Position = GameObject.Find("Piano Sped").transform.position;
      MyPFalse2Position = GameObject.Find("Piano Slow").transform.position;

      isPlank = Physics.CheckSphere(plankCheck.position, groundDistance, groundMask);

    }

    public void playPiano()
    {

        print("piano");
        AudioSource source = GetComponent<AudioSource> ();
        source.Play();

    }

    public void playPianoRight()
    {
      Invoke ("playPiano", 3);
    }

    public void playPianoBad()
    {
      Invoke ("playPiano", 6);
    }

    public int checkifPiPlank()
    {
      if ((MyPianoPosition[0] <= 363.5 && MyPianoPosition[0] >= 362.5) &&
      (MyPianoPosition[1] <= .9 && MyPianoPosition[1] >= .5) &&
      (MyPianoPosition[2] <= 107.5 && MyPianoPosition[2] >= 105))
      {
        return (1);

        } else if ((MyPFalse1Position[0] <= 363.5 && MyPFalse1Position[0] >= 362.5) &&
        (MyPFalse1Position[1] <= .9 && MyPFalse1Position[1] >= .5) &&
        (MyPFalse1Position[2] <= 107.5 && MyPFalse1Position[2] >= 105))
        {
          return (2);

          } else if ((MyPFalse2Position[0] <= 363.5 && MyPFalse2Position[0] >= 362.5) &&
          (MyPFalse2Position[1] <= .9 && MyPFalse2Position[1] >= .5) &&
          (MyPFalse2Position[2] <= 107.5 && MyPFalse2Position[2] >= 105))
          {
            return(3);

          } else if (MyPFalse2Position[1] > 3 || MyPianoPosition[1] > 3 || MyPFalse1Position[1] >3 )
          {
            return(5);
          }

          return (0);
        }

    public void stopPiano()
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

       AudioSource source = GetComponent<AudioSource> ();
       source.Play();
    }

    void OnMouseUp()
    {
      this.transform.parent = null;
      GetComponent<Rigidbody>().useGravity = true;
      GetComponent<Rigidbody>().freezeRotation = false;
      AudioSource source = GetComponent<AudioSource> ();
      source.Stop();
    }

}
