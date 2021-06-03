using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : MonoBehaviour
{

    public Transform theDest;
    public Transform plankCheck;
    public int count = 0;

    public Vector3 MyGuiPosition;
    public Vector3 MyGFalse1Position;
    public Vector3 MyGFalse2Position;

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isPlank;

    void Update() {

      MyGuiPosition = GameObject.Find("Guitar").transform.position;
      MyGFalse1Position = GameObject.Find("Guitar Slow").transform.position;
      MyGFalse2Position = GameObject.Find("Guitar Sped").transform.position;

      isPlank = Physics.CheckSphere(plankCheck.position, groundDistance, groundMask);
    }

    public void playGuitar()
    {
        print("trying to play guitar");
        AudioSource source = GetComponent<AudioSource> ();
        source.Play();
    }

    public void playGuitarRight()
    {
      Invoke ("playGuitar", 3);
    }

    public void playGuitarBad()
    {
      Invoke ("playGuitar", 6);
    }

    public int checkifGuiPlank()
    {
      if ((MyGuiPosition[0] <= 364 && MyGuiPosition[0] >= 362.5) &&
      (MyGuiPosition[1] <= .9 && MyGuiPosition[1] >= .5) &&
      (MyGuiPosition[2] <= 104.5 && MyGuiPosition[2] >= 102.5))
      {
        return (1);

        } else if ((MyGFalse1Position[0] <= 364 && MyGFalse1Position[0] >= 362.5) &&
        (MyGFalse1Position[1] <= .9 && MyGFalse1Position[1] >= .5) &&
        (MyGFalse1Position[2] <= 104.5 && MyGFalse1Position[2] >= 102.5))
        {
          return (2);

          } else if ((MyGFalse2Position[0] <= 364 && MyGFalse2Position[0] >= 362.5) &&
          (MyGFalse2Position[1] <= .9 && MyGFalse2Position[1] >= .5) &&
          (MyGFalse2Position[2] <= 104.5 && MyGFalse2Position[2] >= 102.5))
          {
            return(3);

          } else if (MyGFalse2Position[1] > 3 || MyGuiPosition[1] > 3 || MyGFalse1Position[1] >3 )
          {
            return(5);
          }

          return (0);
        }

    public void stopGuitar()
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
