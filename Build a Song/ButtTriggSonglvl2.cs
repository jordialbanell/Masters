using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtTriggSonglvl2 : MonoBehaviour
{

  private Animator animator;

  public GameObject lvl2acube;
  public GameObject lvl2bcube;
  public GameObject lvl2ccube;
  public GameObject lvl2dcube;

  public Vector3 PositionLevel;

  lvl2acube lvl2acubescript;
  lvl2bcube lvl2bcubescript;
  lvl2ccube lvl2ccubescript;
  lvl2dcube lvl2dcubescript;

  private void Start() {

    lvl2acubescript = lvl2acube.GetComponent<lvl2acube>();
    lvl2bcubescript = lvl2bcube.GetComponent<lvl2bcube>();
    lvl2ccubescript = lvl2ccube.GetComponent<lvl2ccube>();
    lvl2dcubescript = lvl2dcube.GetComponent<lvl2dcube>();
  }

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }

  void Update() {

    PositionLevel = GameObject.Find("levelchecker").transform.position;
  }


  public void Pressed()
  {

    animator.Play("buttlvl2", 0, 0.25f);

    if ((PositionLevel[0] >= 353 && PositionLevel[0] <= 355)
    && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
    && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123))  {

      print("level 2a");
      playMelLvl(1);

    } if ((PositionLevel[0] >= 359 && PositionLevel[0] <= 361)
    && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
    && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123))  {

      print("level 2b");
      playMelLvl(2);

    } if ((PositionLevel[0] >= 368 && PositionLevel[0] <= 370)
    && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
    && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123))  {

      print("level 2c");
      playMelLvl(3);

    } if ((PositionLevel[0] >= 367 && PositionLevel[0] <= 369)
    && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
    && (PositionLevel[2] >= 113 && PositionLevel[2] <= 115))  {

      print("level 2d");
      playMelLvl(4);

  }
}

  public void playMelLvl(int lvl) {

    if (lvl == 1) {

      animator.SetBool("presseda", true);
      lvl2acubescript.playMelody();
      animator.SetBool("pressedb", false);
      animator.SetBool("pressedc", false);
      animator.SetBool("pressedd", false);

    } if (lvl == 2) {

      animator.SetBool("pressedb", true);
      lvl2bcubescript.playMelody();
      animator.SetBool("pressedc", false);
      animator.SetBool("pressedd", false);
      animator.SetBool("presseda", false);

    } if (lvl == 3) {

      animator.SetBool("pressedc", true);
      lvl2ccubescript.playMelody();
      animator.SetBool("pressedb", false);
      animator.SetBool("pressedd", false);
      animator.SetBool("presseda", false);

    } if (lvl == 4) {
      print("lvl4 move!");
      animator.SetBool("pressedd", true);
      lvl2dcubescript.playMelody();
      animator.SetBool("pressedb", false);
      animator.SetBool("presseda", false);
      animator.SetBool("pressedc", false);

  }
}

  public void NotPressed()
  {
    animator.SetBool("pressed", false);
  }

}
