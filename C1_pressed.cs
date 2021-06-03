using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_pressed : MonoBehaviour
{

public int countC1;
public int count;

public Vector3 C1Position;

public List<int> C1PressList;

[SerializeField] public MusicNotesCode C1key;

 void Start()
{
  C1Position = GameObject.Find("C1").transform.position;
}

  public void OnMouseDown()
  {
    C1key.Pressed(1);
    AudioSource source = GetComponent<AudioSource> ();
    source.Play();

    if ((C1Position[0] >= 355) && (C1Position[1] >= 2.3) && (C1Position[2] >= 118))
    {
      countC1 += 1;
    }

    C1PressList.Add(5);
    //countC1 = C1pressed(countC1);
    //print("countC1 = " + countC1);
  }

  public int C1pressed(int count)
  {
    count += 1;
    countC1 = count;
    return (countC1);
  }

  void OnMouseUp()
  {

    AudioSource sourcepick = GetComponent<AudioSource> ();
    sourcepick.Stop();
  }
}
