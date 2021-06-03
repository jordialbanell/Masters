using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_pressed : MonoBehaviour
{

  public int countC;

  public Vector3 CPosition;

  public List<int> CPressList = new List<int>();

  [SerializeField] public MusicNotesCode Ckey;

   void Start()
  {
    CPosition = GameObject.Find("C").transform.position;
  }

  public void OnMouseDown()
  {
    Ckey.Pressed(2);
    AudioSource source = GetComponent<AudioSource> ();
    source.Play();

    if ((CPosition[0] >= 354 && CPosition[0] < 355) && (CPosition[1] >= 2.3) && (CPosition[2] >= 118))
    {
      countC += 1;
    }

    CPressList.Add(5);
    //countC1 = C1pressed(countC1);
    //print("countC1 = " + countC);
  }

  public int Cpressed(int count)
  {
    count += 1;
    countC = count;
    return (countC);
  }

  void OnMouseUp()
  {

    AudioSource sourcepick = GetComponent<AudioSource> ();
    sourcepick.Stop();
  }
}
