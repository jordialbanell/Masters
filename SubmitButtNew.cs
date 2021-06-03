using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitButtNew : MonoBehaviour
{

  public GameObject piano;
  public GameObject piano1;
  public GameObject piano2;

  public GameObject vocal;
  public GameObject vocal1;
  public GameObject vocal2;

  public GameObject drums;
  public GameObject drums1;
  public GameObject drums2;

  public GameObject guitar;
  public GameObject guitar1;
  public GameObject guitar2;

  public GameObject guitarFirst;
  public GameObject pianoFirst;
  public GameObject drumsFirst;

  public GameObject videoPlayer;

  Piano piano_scriptgood;
  Piano piano_scriptbad1;
  Piano piano_scriptbad2;

  Vocal vocal_scriptgood;
  Vocal vocal_scriptbad1;
  Vocal vocal_scriptbad2;

  Drums drums_scriptgood;
  Drums drums_scriptbad1;
  Drums drums_scriptbad2;

  Guitar guitar_scriptgood;
  Guitar guitar_scriptbad1;
  Guitar guitar_scriptbad2;

  New new_scriptguitar;
  New new_scriptpiano;
  New new_scriptdrums;

  private Animator animator;

  private float delayBeforeLoad =  100f;
  private string sceneNameToLoad;
  private float timeElapsed;
  private int buttpressed;
  private int checking = 0;

  public Vector3 center;

  private int xPos;
  private int zPos;
  private int xPos2;
  private int zPos2;
  private int xPos3;
  private int zPos3;

  private int xPosd;
  private int zPosd;
  private int xPos2d;
  private int zPos2d;
  private int xPos3d;
  private int zPos3d;

  private int xPosp;
  private int zPosp;
  private int xPos2p;
  private int zPos2p;
  private int xPos3p;
  private int zPos3p;

  private int xPosg;
  private int zPosg;
  private int xPos2g;
  private int zPos2g;
  private int xPos3g;
  private int zPos3g;

  private int xPosn;
  private int zPosn;
  private int xPos2n;
  private int zPos2n;
  private int xPos3n;
  private int zPos3n;

  public int gameStart;

  void Start()
  {
    videoPlayer.SetActive(false);

    print(xPos + " " + zPos);

    piano_scriptgood = piano.GetComponent<Piano>();
    piano_scriptbad1 = piano1.GetComponent<Piano>();
    piano_scriptbad2 = piano2.GetComponent<Piano>();

    vocal_scriptgood = vocal.GetComponent<Vocal>();
    vocal_scriptbad1 = vocal1.GetComponent<Vocal>();
    vocal_scriptbad2 = vocal2.GetComponent<Vocal>();

    drums_scriptgood = drums.GetComponent<Drums>();
    drums_scriptbad1 = drums1.GetComponent<Drums>();
    drums_scriptbad2 = drums2.GetComponent<Drums>();

    guitar_scriptgood = guitar.GetComponent<Guitar>();
    guitar_scriptbad1 = guitar1.GetComponent<Guitar>();
    guitar_scriptbad2 = guitar2.GetComponent<Guitar>();

    new_scriptguitar = guitarFirst.GetComponent<New>();
    new_scriptpiano = pianoFirst.GetComponent<New>();
    new_scriptdrums = drumsFirst.GetComponent<New>();

    if (gameStart == 0)
    {
      gameStart = 1;
      MoveObject();

    }
  }

  public void scenes(int scene)
  {
    int DrumOnPlank = drums_scriptgood.checkifDruPlank();
    int VocOnPlank = vocal_scriptgood.checkifVocPlank();
    int PiOnPlank = piano_scriptgood.checkifPiPlank();
    int GuiOnPlank = guitar_scriptgood.checkifGuiPlank();

    if (scene == 1)
    {
      print("hello?");
      SceneChange("lvl2");
      MoveObjectLvl2();

      } else if (scene == 2)
      {
        SceneChange("lvl3");
        MoveObjectLvl3();

        } else if (scene == 3)
        {
          SceneChange("lv4still");
          MoveObjectLvl4();

        }
      }

      void MoveObject()
      {

        xPos = Random.Range(344, 360);
        zPos = Random.Range(100, 118);
        xPos2 = Random.Range(344, 360);
        zPos2 = Random.Range(100, 118);
        xPos3 = Random.Range(344, 360);
        zPos3 = Random.Range(100, 118);

        while ((xPos >= 350 && xPos <= 357) && (zPos >= 111 && zPos <= 115) &
        (xPos2 >= 350 && xPos2 <= 357) && (zPos2 >= 111 && zPos2 <= 115) &
        (xPos3 >= 350 && xPos3 <= 357) && (zPos3 >= 111 && zPos3 <= 115))

        {
          xPos = Random.Range(344, 360);
          zPos = Random.Range(100, 118);

          xPos2 = Random.Range(344, 360);
          zPos2 = Random.Range(100, 118);

          xPos3 = Random.Range(344, 360);
          zPos3 = Random.Range(100, 118);
        }

        vocal.transform.position = new Vector3(xPos, 1, zPos);
        vocal1.transform.position = new Vector3(xPos2, 1, zPos2);
        vocal2.transform.position = new Vector3(xPos3, 1, zPos3);

        print("moved vocal to " + xPos + " " + zPos);
        print("moved vocal to " + xPos2 + " " + zPos2);
        print("moved vocal to " + xPos3 + " " + zPos3);
      }

      void MoveObjectLvl2()
      {

        xPosd = Random.Range(344, 360);
        zPosd = Random.Range(100, 118);
        xPos2d = Random.Range(344, 360);
        zPos2d = Random.Range(100, 118);
        xPos3d = Random.Range(344, 360);
        zPos3d = Random.Range(100, 118);

        while (((xPosd >= 350 && xPosd <= 357) && (zPosd >= 111 && zPosd <= 115)) ||
        ((xPos2d >= 350 && xPos2d <= 357) && (zPos2d >= 111 && zPos2d <= 115)) ||
        ((xPos3d >= 350 && xPos3d <= 357) && (zPos3d >= 111 && zPos3d <= 115)))

        {

          xPosd = Random.Range(344, 360);
          zPosd = Random.Range(100, 118);
          xPos2d = Random.Range(344, 360);
          zPos2d = Random.Range(100, 118);
          xPos3d = Random.Range(344, 360);
          zPos3d = Random.Range(100, 118);
        }

        drums.transform.position = new Vector3(xPosd, 1, zPosd);
        drums1.transform.position = new Vector3(xPos2d, 1, zPos2d);
        drums2.transform.position = new Vector3(xPos3d, 1, zPos3d);

        print("moved drum to " + xPosd + " " + zPosd);
        print("moved drum1 to " + xPos2d + " " + zPos2d);
        print("moved drum2 to " + xPos3d + " " + zPos3d);
      }

      void MoveObjectLvl3()
      {

        xPos = Random.Range(344, 360);
        zPos = Random.Range(100, 118);
        xPos2 = Random.Range(344, 360);
        zPos2 = Random.Range(100, 118);
        xPos3 = Random.Range(344, 360);
        zPos3 = Random.Range(100, 118);

        xPosd = Random.Range(344, 360);
        zPosd = Random.Range(100, 118);
        xPos2d = Random.Range(344, 360);
        zPos2d = Random.Range(100, 118);
        xPos3d = Random.Range(344, 360);
        zPos3d = Random.Range(100, 118);

        xPosp = Random.Range(344, 360);
        zPosp = Random.Range(100, 118);
        xPos2p = Random.Range(344, 360);
        zPos2p = Random.Range(100, 118);
        xPos3p = Random.Range(344, 360);
        zPos3p = Random.Range(100, 118);

        while (((xPos >= 350 && xPos <= 357) && (zPos >= 111 && zPos <= 115)) ||
        ((xPos2 >= 350 && xPos2 <= 357) && (zPos2 >= 111 && zPos2 <= 115)) ||
        ((xPos3 >= 350 && xPos3 <= 357) && (zPos3 >= 111 && zPos3 <= 115)) ||
        ((xPosd >= 350 && xPosd <= 357) && (zPosd >= 111 && zPosd <= 115)) ||
        ((xPos2d >= 350 && xPos2d <= 357) && (zPos2d >= 111 && zPos2d <= 115)) ||
        ((xPos3d >= 350 && xPos3d <= 357) && (zPos3d >= 111 && zPos3d <= 115)) ||
        ((xPosp >= 350 && xPosp <= 357) && (zPosp >= 111 && zPosp <= 115)) ||
        ((xPos2p >= 350 && xPos2p <= 357) && (zPos2p >= 111 && zPos2p <= 115)) ||
        ((xPos3p >= 350 && xPos3p <= 357) && (zPos3p >= 111 && zPos3p <= 115)))

        {
          xPos = Random.Range(344, 360);
          zPos = Random.Range(100, 118);
          xPos2 = Random.Range(344, 360);
          zPos2 = Random.Range(100, 118);
          xPos3 = Random.Range(344, 360);
          zPos3 = Random.Range(100, 118);

          xPosd = Random.Range(344, 360);
          zPosd = Random.Range(100, 118);
          xPos2d = Random.Range(344, 360);
          zPos2d = Random.Range(100, 118);
          xPos3d = Random.Range(344, 360);
          zPos3d = Random.Range(100, 118);

          xPosp = Random.Range(344, 360);
          zPosp = Random.Range(100, 118);
          xPos2p = Random.Range(344, 360);
          zPos2p = Random.Range(100, 118);
          xPos3p = Random.Range(344, 360);
          zPos3p = Random.Range(100, 118);
        }

        vocal.transform.position = new Vector3(xPos, 1, zPos);
        vocal1.transform.position = new Vector3(xPos2, 1, zPos2);
        vocal2.transform.position = new Vector3(xPos3, 1, zPos3);

        drums.transform.position = new Vector3(xPosd, 1, zPosd);
        drums1.transform.position = new Vector3(xPos2d, 1, zPos2d);
        drums2.transform.position = new Vector3(xPos3d, 1, zPos3d);

        piano.transform.position = new Vector3(xPosp, 1, zPosp);
        piano1.transform.position = new Vector3(xPos2p, 1, zPos2p);
        piano2.transform.position = new Vector3(xPos3p, 1, zPos3p);

        print("moved vocal to " + xPos + " " + zPos);
        print("moved vocal1 to " + xPos2 + " " + zPos2);
        print("moved vocal2 to " + xPos3 + " " + zPos3);

        print("moved drum to " + xPosd + " " + zPosd);
        print("moved drum1 to " + xPos2d + " " + zPos2d);
        print("moved drum2 to " + xPos3d + " " + zPos3d);

        print("moved piano to " + xPosp + " " + zPosp);
        print("moved piano1 to " + xPos2p + " " + zPos2p);
        print("moved piano2 to " + xPos3p + " " + zPos3p);
      }

      void MoveObjectLvl4()
      {

        xPos = Random.Range(344, 360);
        zPos = Random.Range(100, 118);
        xPos2 = Random.Range(344, 360);
        zPos2 = Random.Range(100, 118);
        xPos3 = Random.Range(344, 360);
        zPos3 = Random.Range(100, 118);

        xPosd = Random.Range(344, 360);
        zPosd = Random.Range(100, 118);
        xPos2d = Random.Range(344, 360);
        zPos2d = Random.Range(100, 118);
        xPos3d = Random.Range(344, 360);
        zPos3d = Random.Range(100, 118);

        xPosp = Random.Range(344, 360);
        zPosp = Random.Range(100, 118);
        xPos2p = Random.Range(344, 360);
        zPos2p = Random.Range(100, 118);
        xPos3p = Random.Range(344, 360);
        zPos3p = Random.Range(100, 118);

        xPosg = Random.Range(344, 360);
        zPosg = Random.Range(100, 118);
        xPos2g = Random.Range(344, 360);
        zPos2g = Random.Range(100, 118);
        xPos3g = Random.Range(344, 360);
        zPos3g = Random.Range(100, 118);

        while (((xPos >= 350 && xPos <= 357) && (zPos >= 111 && zPos <= 115)) ||
        ((xPos2 >= 350 && xPos2 <= 357) && (zPos2 >= 111 && zPos2 <= 115)) ||
        ((xPos3 >= 350 && xPos3 <= 357) && (zPos3 >= 111 && zPos3 <= 115)) ||
        ((xPosd >= 350 && xPosd <= 357) && (zPosd >= 111 && zPosd <= 115)) ||
        ((xPos2d >= 350 && xPos2d <= 357) && (zPos2d >= 111 && zPos2d <= 115)) ||
        ((xPos3d >= 350 && xPos3d <= 357) && (zPos3d >= 111 && zPos3d <= 115)) ||
        ((xPosp >= 350 && xPosp <= 357) && (zPosp >= 111 && zPosp <= 115)) ||
        ((xPos2p >= 350 && xPos2p <= 357) && (zPos2p >= 111 && zPos2p <= 115)) ||
        ((xPos3p >= 350 && xPos3p <= 357) && (zPos3p >= 111 && zPos3p <= 115))||
        ((xPosg >= 350 && xPosg <= 357) && (zPosg >= 111 && zPosg <= 115)) ||
        ((xPos2g >= 350 && xPos2g <= 357) && (zPos2g >= 111 && zPos2g <= 115)) ||
        ((xPos3g >= 350 && xPos3g <= 357) && (zPos3g >= 111 && zPos3g <= 115)))

        {
          xPos = Random.Range(344, 360);
          zPos = Random.Range(100, 118);
          xPos2 = Random.Range(344, 360);
          zPos2 = Random.Range(100, 118);
          xPos3 = Random.Range(344, 360);
          zPos3 = Random.Range(100, 118);

          xPosd = Random.Range(344, 360);
          zPosd = Random.Range(100, 118);
          xPos2d = Random.Range(344, 360);
          zPos2d = Random.Range(100, 118);
          xPos3d = Random.Range(344, 360);
          zPos3d = Random.Range(100, 118);

          xPosp = Random.Range(344, 360);
          zPosp = Random.Range(100, 118);
          xPos2p = Random.Range(344, 360);
          zPos2p = Random.Range(100, 118);
          xPos3p = Random.Range(344, 360);
          zPos3p = Random.Range(100, 118);

          xPosg = Random.Range(344, 360);
          zPosg = Random.Range(100, 118);
          xPos2g = Random.Range(344, 360);
          zPos2g = Random.Range(100, 118);
          xPos3g = Random.Range(344, 360);
          zPos3g = Random.Range(100, 118);
        }

        vocal.transform.position = new Vector3(xPos, 1, zPos);
        vocal1.transform.position = new Vector3(xPos2, 1, zPos2);
        vocal2.transform.position = new Vector3(xPos3, 1, zPos3);

        drums.transform.position = new Vector3(xPosd, 1, zPosd);
        drums1.transform.position = new Vector3(xPos2d, 1, zPos2d);
        drums2.transform.position = new Vector3(xPos3d, 1, zPos3d);

        piano.transform.position = new Vector3(xPosp, 1, zPosp);
        piano1.transform.position = new Vector3(xPos2p, 1, zPos2p);
        piano2.transform.position = new Vector3(xPos3p, 1, zPos3p);

        guitar.transform.position = new Vector3(xPosg, 1, zPosg);
        guitar1.transform.position = new Vector3(xPos2g, 1, zPos2g);
        guitar2.transform.position = new Vector3(xPos3g, 1, zPos3g);

        print("moved vocal to " + xPos + " " + zPos);
        print("moved vocal1 to " + xPos2 + " " + zPos2);
        print("moved vocal2 to " + xPos3 + " " + zPos3);

        print("moved drum to " + xPosd + " " + zPosd);
        print("moved drum1 to " + xPos2d + " " + zPos2d);
        print("moved drum2 to " + xPos3d + " " + zPos3d);

        print("moved piano to " + xPosp + " " + zPosp);
        print("moved piano1 to " + xPos2p + " " + zPos2p);
        print("moved piano2 to " + xPos3p + " " + zPos3p);

        print("moved guitar to " + xPosg + " " + zPosg);
        print("moved guitar1 to " + xPos2g + " " + zPos2g);
        print("moved guitar2 to " + xPos3g + " " + zPos3g);
      }


      private void Awake()
      {
        animator = GetComponent<Animator>();
      }

      public void SceneChange(string scenename)
      {
        SceneManager.LoadScene(scenename);
      }

      public void Pressed()
      {
        buttpressed = 1;

        vocal_scriptgood.stopVocals();
        drums_scriptgood.stopDrums();
        piano_scriptgood.stopPiano();
        guitar_scriptgood.stopGuitar();

        animator.Play("SubmitButton", 0, 0.1f);

        int DrumOnPlank = drums_scriptgood.checkifDruPlank();
        int VocOnPlank = vocal_scriptgood.checkifVocPlank();
        int PiOnPlank = piano_scriptgood.checkifPiPlank();
        int GuiOnPlank = guitar_scriptgood.checkifGuiPlank();

        if (VocOnPlank == 1 && DrumOnPlank == 1 && PiOnPlank == 1 && GuiOnPlank == 1)
        {
          print("all 4 are on");
          animator.SetBool("AllGood", true);
          videoPlayer.SetActive(true);

          vocal_scriptgood.playVocals();
          drums_scriptgood.playDrums();
          piano_scriptgood.playPiano();
          guitar_scriptgood.playGuitar();

          animator.SetBool("ActualDrum", true);
          animator.SetBool("ActualPiano", true);
          animator.SetBool("ActualGuitar", true);

          animator.SetBool("CorrectD", false);
          animator.SetBool("CorrectV", false);
          animator.SetBool("CorrectP", false);
          animator.SetBool("False2V", false);
          animator.SetBool("False1V", false);
          animator.SetBool("False2D", false);
          animator.SetBool("False1D", false);
          animator.SetBool("False2P", false);
          animator.SetBool("False1P", false);
          animator.SetBool("False1G", false);
          animator.SetBool("False2G", false);
          animator.SetBool("CorrectG", false);
          animator.SetBool("BothVD", false);
          animator.SetBool("BothPV", false);
          animator.SetBool("BothPD", false);
          animator.SetBool("None", false);

          } else if (PiOnPlank == 2)
          {
            print("Pi Slow down On");
            animator.SetBool("False1P", true);

            animator.SetBool("ActualDrum", false);
            animator.SetBool("ActualPiano", false);
            animator.SetBool("ActualGuitar", false);

            animator.SetBool("CorrectD", false);
            animator.SetBool("CorrectP", false);
            animator.SetBool("CorrectV", false);
            animator.SetBool("False2V", false);
            animator.SetBool("False1V", false);
            animator.SetBool("False2D", false);
            animator.SetBool("False1D", false);
            animator.SetBool("False2P", false);
            animator.SetBool("False1G", false);
            animator.SetBool("False2G", false);
            animator.SetBool("CorrectG", false);
            animator.SetBool("AllP", false);
            animator.SetBool("BothVD", false);
            animator.SetBool("BothPV", false);
            animator.SetBool("BothPD", false);
            animator.SetBool("None", false);

            } else if (PiOnPlank == 3)
            {
              print("Pi Sped up On");

              animator.SetBool("False2P", true);

              animator.SetBool("ActualDrum", false);
              animator.SetBool("ActualPiano", false);
              animator.SetBool("ActualGuitar", false);

              animator.SetBool("CorrectD", false);
              animator.SetBool("CorrectV", false);
              animator.SetBool("CorrectP", false);
              animator.SetBool("False2V", false);
              animator.SetBool("False1V", false);
              animator.SetBool("False2D", false);
              animator.SetBool("False1D", false);
              animator.SetBool("False1P", false);
              animator.SetBool("False1G", false);
              animator.SetBool("False2G", false);
              animator.SetBool("CorrectG", false);
              animator.SetBool("AllP", false);
              animator.SetBool("BothVD", false);
              animator.SetBool("BothPV", false);
              animator.SetBool("BothPD", false);
              animator.SetBool("None", false);

              } else if (DrumOnPlank == 2)
              {
                print("Drum Slow down On");
                animator.SetBool("False1D", true);

                animator.SetBool("ActualDrum", false);
                animator.SetBool("ActualPiano", false);
                animator.SetBool("ActualGuitar", false);

                animator.SetBool("CorrectD", false);
                animator.SetBool("CorrectP", false);
                animator.SetBool("CorrectV", false);
                animator.SetBool("False2V", false);
                animator.SetBool("False1V", false);
                animator.SetBool("False2D", false);
                animator.SetBool("False2P", false);
                animator.SetBool("False1P", false);
                animator.SetBool("False1G", false);
                animator.SetBool("False2G", false);
                animator.SetBool("CorrectG", false);
                animator.SetBool("AllP", false);
                animator.SetBool("BothVD", false);
                animator.SetBool("BothPV", false);
                animator.SetBool("BothPD", false);
                animator.SetBool("None", false);

                } else if (DrumOnPlank == 3)
                {
                  print("Drum Sped up On");
                  animator.SetBool("False2D", true);

                  animator.SetBool("ActualDrum", false);
                  animator.SetBool("ActualPiano", false);
                  animator.SetBool("ActualGuitar", false);

                  animator.SetBool("CorrectD", false);
                  animator.SetBool("CorrectV", false);
                  animator.SetBool("CorrectP", false);
                  animator.SetBool("False2V", false);
                  animator.SetBool("False1V", false);
                  animator.SetBool("False1D", false);
                  animator.SetBool("False2P", false);
                  animator.SetBool("False1P", false);
                  animator.SetBool("False1G", false);
                  animator.SetBool("False2G", false);
                  animator.SetBool("CorrectG", false);
                  animator.SetBool("AllP", false);
                  animator.SetBool("BothVD", false);
                  animator.SetBool("BothPV", false);
                  animator.SetBool("BothPD", false);
                  animator.SetBool("None", false);

                  } else if (VocOnPlank == 2)
                  {
                    print("Voc Slow down On");

                    animator.SetBool("False1V", true);

                    animator.SetBool("ActualDrum", false);
                    animator.SetBool("ActualPiano", false);
                    animator.SetBool("ActualGuitar", false);

                    animator.SetBool("CorrectD", false);
                    animator.SetBool("CorrectV", false);
                    animator.SetBool("CorrectP", false);
                    animator.SetBool("False2V", false);
                    animator.SetBool("False2D", false);
                    animator.SetBool("False1D", false);
                    animator.SetBool("False2P", false);
                    animator.SetBool("False1P", false);
                    animator.SetBool("False1G", false);
                    animator.SetBool("False2G", false);
                    animator.SetBool("CorrectG", false);
                    animator.SetBool("AllP", false);
                    animator.SetBool("BothVD", false);
                    animator.SetBool("BothPV", false);
                    animator.SetBool("BothPD", false);
                    animator.SetBool("None", false);

                    } else if (VocOnPlank == 3)
                    {
                      print("Voc Sped up On");
                      animator.SetBool("False2V", true);

                      animator.SetBool("ActualDrum", false);
                      animator.SetBool("ActualPiano", false);
                      animator.SetBool("ActualGuitar", false);

                      animator.SetBool("CorrectD", false);
                      animator.SetBool("CorrectV", false);
                      animator.SetBool("CorrectP", false);
                      animator.SetBool("False1V", false);
                      animator.SetBool("False2D", false);
                      animator.SetBool("False1D", false);
                      animator.SetBool("False2P", false);
                      animator.SetBool("False1P", false);
                      animator.SetBool("False1G", false);
                      animator.SetBool("False2G", false);
                      animator.SetBool("CorrectG", false);
                      animator.SetBool("AllP", false);
                      animator.SetBool("BothVD", false);
                      animator.SetBool("BothPV", false);
                      animator.SetBool("BothPD", false);
                      animator.SetBool("None", false);

                      } else if (GuiOnPlank == 2)
                      {
                        print("Guitar Slow down On");
                        animator.SetBool("False1G", true);

                        animator.SetBool("ActualDrum", false);
                        animator.SetBool("ActualPiano", false);
                        animator.SetBool("ActualGuitar", false);

                        animator.SetBool("False1V", false);
                        animator.SetBool("CorrectD", false);
                        animator.SetBool("CorrectV", false);
                        animator.SetBool("CorrectP", false);
                        animator.SetBool("False2V", false);
                        animator.SetBool("False2D", false);
                        animator.SetBool("False1D", false);
                        animator.SetBool("False2P", false);
                        animator.SetBool("False1P", false);
                        animator.SetBool("False2G", false);
                        animator.SetBool("CorrectG", false);
                        animator.SetBool("AllP", false);
                        animator.SetBool("BothVD", false);
                        animator.SetBool("BothPV", false);
                        animator.SetBool("BothPD", false);
                        animator.SetBool("None", false);

                        } else if (GuiOnPlank == 3)
                        {
                          print("Guitar Sped up On");
                          animator.SetBool("False2G", true);

                          animator.SetBool("ActualDrum", false);
                          animator.SetBool("ActualPiano", false);

                          animator.SetBool("False1G", false);
                          animator.SetBool("CorrectG", false);
                          animator.SetBool("False2V", false);
                          animator.SetBool("CorrectD", false);
                          animator.SetBool("CorrectV", false);
                          animator.SetBool("CorrectP", false);
                          animator.SetBool("False1V", false);
                          animator.SetBool("False2D", false);
                          animator.SetBool("False1D", false);
                          animator.SetBool("False2P", false);
                          animator.SetBool("False1P", false);
                          animator.SetBool("AllP", false);
                          animator.SetBool("BothVD", false);
                          animator.SetBool("BothPV", false);
                          animator.SetBool("BothPD", false);
                          animator.SetBool("None", false);

                          } else if (PiOnPlank == 1 && VocOnPlank == 0 && DrumOnPlank == 0)
                          {
                            print("Piano is on");
                            animator.SetBool("CorrectP", true);

                            animator.SetBool("ActualPiano", true);
                            animator.SetBool("ActualDrum", false);

                            animator.SetBool("CorrectD", false);
                            animator.SetBool("CorrectV", false);
                            animator.SetBool("False2V", false);
                            animator.SetBool("False1V", false);
                            animator.SetBool("False2D", false);
                            animator.SetBool("False1D", false);
                            animator.SetBool("False2P", false);
                            animator.SetBool("False1P", false);
                            animator.SetBool("False1G", false);
                            animator.SetBool("False2G", false);
                            animator.SetBool("CorrectG", false);
                            animator.SetBool("AllP", false);
                            animator.SetBool("BothVD", false);
                            animator.SetBool("BothPV", false);
                            animator.SetBool("BothPD", false);
                            animator.SetBool("None", false);

                            } else if (PiOnPlank == 1  && DrumOnPlank == 1 && VocOnPlank == 1 && GuiOnPlank == 0)
                            {
                              print("Piano Drum and Voc on");

                              animator.SetBool("ActualDrum", true);
                              animator.SetBool("ActualPiano", true);
                              videoPlayer.SetActive(true);

                              animator.SetBool("PDVGood", true);
                              animator.SetBool("BothPD", false);
                              animator.SetBool("CorrectD", false);
                              animator.SetBool("CorrectV", false);
                              animator.SetBool("CorrectP", false);
                              animator.SetBool("False2V", false);
                              animator.SetBool("False1V", false);
                              animator.SetBool("False2D", false);
                              animator.SetBool("False1D", false);
                              animator.SetBool("False2P", false);
                              animator.SetBool("False1P", false);
                              animator.SetBool("False1G", false);
                              animator.SetBool("False2G", false);
                              animator.SetBool("CorrectG", false);
                              animator.SetBool("AllP", false);
                              animator.SetBool("BothVD", false);
                              animator.SetBool("BothPV", false);
                              animator.SetBool("None", false);

                              } else if (PiOnPlank == 1  && DrumOnPlank == 1 && VocOnPlank == 1 && GuiOnPlank == 5 && checking == 0)
                              {
                                print("Piano Drum and Vocal on, lvl3 done");

                                piano_scriptgood.playPiano();
                                drums_scriptgood.playDrums();
                                vocal_scriptgood.playVocals();

                                animator.SetBool("ActualDrum", true);
                                animator.SetBool("ActualPiano", true);
                                videoPlayer.SetActive(true);

                                animator.SetBool("Lvl3Pass", true);
                                animator.SetBool("PDVGood", false);
                                animator.SetBool("BothPD", false);
                                animator.SetBool("CorrectD", false);
                                animator.SetBool("CorrectV", false);
                                animator.SetBool("CorrectP", false);
                                animator.SetBool("False2V", false);
                                animator.SetBool("False1V", false);
                                animator.SetBool("False2D", false);
                                animator.SetBool("False1D", false);
                                animator.SetBool("False2P", false);
                                animator.SetBool("False1P", false);
                                animator.SetBool("False1G", false);
                                animator.SetBool("False2G", false);
                                animator.SetBool("CorrectG", false);
                                animator.SetBool("AllP", false);
                                animator.SetBool("BothVD", false);
                                animator.SetBool("BothPV", false);
                                animator.SetBool("None", false);

                                checking = 1;

                                } else if (PiOnPlank == 1  && DrumOnPlank == 1 && VocOnPlank == 1 && GuiOnPlank == 5 && checking == 1)
                                {
                                  print("lvl4 here we come");

                                  checking = 0;
                                  scenes(3);

                                  } else if (PiOnPlank == 1  && DrumOnPlank == 1 && GuiOnPlank == 1)
                                  {
                                    print("Piano Drum and Guitar on");

                                    animator.SetBool("PDGGood", true);

                                    animator.SetBool("ActualDrum", true);
                                    animator.SetBool("ActualPiano", true);
                                    animator.SetBool("ActualGuitar", true);

                                    animator.SetBool("PDVGood", false);
                                    animator.SetBool("Lvl3Pass", false);
                                    animator.SetBool("BothPD", false);
                                    animator.SetBool("CorrectD", false);
                                    animator.SetBool("CorrectV", false);
                                    animator.SetBool("CorrectP", false);
                                    animator.SetBool("False2V", false);
                                    animator.SetBool("False1V", false);
                                    animator.SetBool("False2D", false);
                                    animator.SetBool("False1D", false);
                                    animator.SetBool("False2P", false);
                                    animator.SetBool("False1P", false);
                                    animator.SetBool("False1G", false);
                                    animator.SetBool("False2G", false);
                                    animator.SetBool("AllP", false);
                                    animator.SetBool("BothVD", false);
                                    animator.SetBool("BothPV", false);
                                    animator.SetBool("None", false);

                                    } else if (PiOnPlank == 1  && DrumOnPlank == 1)
                                    {
                                      print("Piano and Drum");

                                      animator.SetBool("ActualDrum", true);
                                      animator.SetBool("ActualPiano", true);
                                      animator.SetBool("ActualGuitar", false);

                                      animator.SetBool("BothPD", true);

                                      animator.SetBool("CorrectD", false);
                                      animator.SetBool("CorrectV", false);
                                      animator.SetBool("CorrectP", false);
                                      animator.SetBool("False2V", false);
                                      animator.SetBool("False1V", false);
                                      animator.SetBool("False2D", false);
                                      animator.SetBool("False1D", false);
                                      animator.SetBool("False2P", false);
                                      animator.SetBool("False1P", false);
                                      animator.SetBool("False1G", false);
                                      animator.SetBool("False2G", false);
                                      animator.SetBool("CorrectG", false);
                                      animator.SetBool("AllP", false);
                                      animator.SetBool("BothVD", false);
                                      animator.SetBool("BothPV", false);
                                      animator.SetBool("None", false);

                                      } else if (VocOnPlank == 1 && PiOnPlank == 1 && DrumOnPlank == 0)
                                      {
                                        print("Voc and Piano is on");
                                        videoPlayer.SetActive(true);

                                        animator.SetBool("ActualDrum", false);
                                        animator.SetBool("ActualPiano", true);
                                        animator.SetBool("BothPV", true);
                                        animator.SetBool("CorrectD", false);
                                        animator.SetBool("CorrectP", false);
                                        animator.SetBool("CorrectV", false);
                                        animator.SetBool("False2V", false);
                                        animator.SetBool("False1V", false);
                                        animator.SetBool("False2D", false);
                                        animator.SetBool("False1D", false);
                                        animator.SetBool("False2P", false);
                                        animator.SetBool("False1P", false);
                                        animator.SetBool("False1G", false);
                                        animator.SetBool("False2G", false);
                                        animator.SetBool("CorrectG", false);
                                        animator.SetBool("AllP", false);
                                        animator.SetBool("BothVD", false);
                                        animator.SetBool("BothPD", false);
                                        animator.SetBool("None", false);

                                        } else if (VocOnPlank == 1 && PiOnPlank == 5 && DrumOnPlank == 1 && GuiOnPlank == 5 && checking == 0)
                                        {
                                          print("Voc and Drum is on, Lvl2 done");
                                          videoPlayer.SetActive(true);

                                          vocal_scriptgood.playVocals();
                                          drums_scriptgood.playDrums();

                                          animator.SetBool("Lvl2Good", true);

                                          animator.SetBool("ActualDrum", false);
                                          animator.SetBool("ActualPiano", false);
                                          animator.SetBool("BothPV", false);
                                          animator.SetBool("CorrectD", false);
                                          animator.SetBool("CorrectP", false);
                                          animator.SetBool("CorrectV", false);
                                          animator.SetBool("False2V", false);
                                          animator.SetBool("False1V", false);
                                          animator.SetBool("False2D", false);
                                          animator.SetBool("False1D", false);
                                          animator.SetBool("False2P", false);
                                          animator.SetBool("False1P", false);
                                          animator.SetBool("False1G", false);
                                          animator.SetBool("False2G", false);
                                          animator.SetBool("CorrectG", false);
                                          animator.SetBool("AllP", false);
                                          animator.SetBool("BothVD", false);
                                          animator.SetBool("BothPD", false);
                                          animator.SetBool("None", false);

                                          checking = 1;

                                          } else if (VocOnPlank == 1 && PiOnPlank == 5 && DrumOnPlank == 1 && GuiOnPlank == 5 && checking == 1)
                                          {
                                            print("lvl3 we come");

                                            checking = 0;
                                            scenes(2);

                                            } else if (VocOnPlank == 1  && DrumOnPlank == 1)
                                            {
                                              print("Voc and Drum");
                                              animator.SetBool("BothVD", true);

                                              animator.SetBool("ActualDrum", true);
                                              animator.SetBool("ActualPiano", false);
                                              animator.SetBool("ActualGuitar", false);


                                              animator.SetBool("CorrectD", false);
                                              animator.SetBool("CorrectP", false);
                                              animator.SetBool("CorrectV", false);
                                              animator.SetBool("False2V", false);
                                              animator.SetBool("False1V", false);
                                              animator.SetBool("False2D", false);
                                              animator.SetBool("False1D", false);
                                              animator.SetBool("False2P", false);
                                              animator.SetBool("False1P", false);
                                              animator.SetBool("False1G", false);
                                              animator.SetBool("False2G", false);
                                              animator.SetBool("CorrectG", false);
                                              animator.SetBool("AllP", false);
                                              animator.SetBool("BothPV", false);
                                              animator.SetBool("BothPD", false);
                                              animator.SetBool("None", false);

                                              } else if (VocOnPlank == 1 && DrumOnPlank == 5 && PiOnPlank == 5 && GuiOnPlank == 5 && checking == 0)
                                              {
                                                print("Lvl1 is good");
                                                checking = 1;

                                                videoPlayer.SetActive(true);
                                                vocal_scriptgood.actuallyPlay();

                                                animator.SetBool("Lvl1Good", true);

                                                animator.SetBool("ActualGuitar", false);
                                                animator.SetBool("ActualDrum", false);
                                                animator.SetBool("ActualPiano", false);

                                                animator.SetBool("CorrectV", false);
                                                animator.SetBool("CorrectD", false);
                                                animator.SetBool("CorrectP", false);
                                                animator.SetBool("False2V", false);
                                                animator.SetBool("False1V", false);
                                                animator.SetBool("False2D", false);
                                                animator.SetBool("False1D", false);
                                                animator.SetBool("False2P", false);
                                                animator.SetBool("False1P", false);
                                                animator.SetBool("False1G", false);
                                                animator.SetBool("False2G", false);
                                                animator.SetBool("CorrectG", false);
                                                animator.SetBool("AllP", false);
                                                animator.SetBool("BothVD", false);
                                                animator.SetBool("BothPV", false);
                                                animator.SetBool("BothPD", false);
                                                animator.SetBool("None", false);


                                                } else if (VocOnPlank == 1 && DrumOnPlank == 5 && PiOnPlank == 5 && GuiOnPlank == 5 && checking == 1)
                                                {
                                                  print("scene 2 here we come");
                                                  checking = 0;

                                                  scenes(1);
                                                  //level 2 scene call

                                                  } else if (DrumOnPlank == 1 && VocOnPlank == 0 && PiOnPlank == 0)
                                                  {
                                                    print("Drum is on");
                                                    //drums_scriptgood.playDrums();

                                                    animator.SetBool("ActualDrum", true);
                                                    animator.SetBool("ActualPiano", false);
                                                    animator.SetBool("ActualGuitar", false);

                                                    animator.SetBool("CorrectD", true);
                                                    animator.SetBool("CorrectV", false);
                                                    animator.SetBool("CorrectP", false);
                                                    animator.SetBool("False2V", false);
                                                    animator.SetBool("False1V", false);
                                                    animator.SetBool("False2D", false);
                                                    animator.SetBool("False1D", false);
                                                    animator.SetBool("False2P", false);
                                                    animator.SetBool("False1P", false);
                                                    animator.SetBool("False1G", false);
                                                    animator.SetBool("False2G", false);
                                                    animator.SetBool("CorrectG", false);
                                                    animator.SetBool("AllP", false);
                                                    animator.SetBool("BothVD", false);
                                                    animator.SetBool("BothPV", false);
                                                    animator.SetBool("BothPD", false);
                                                    animator.SetBool("None", false);

                                                    } else if (GuiOnPlank == 1 && (VocOnPlank == 0 || PiOnPlank == 0 ||  DrumOnPlank == 0))
                                                    {
                                                      print("Guitar is on");
                                                      //drums_scriptgood.playDrums();

                                                      animator.SetBool("ActualDrum", false);
                                                      animator.SetBool("ActualGuitar", true);
                                                      animator.SetBool("ActualPiano", false);

                                                      animator.SetBool("CorrectG", true);

                                                      animator.SetBool("CorrectD", false);
                                                      animator.SetBool("CorrectV", false);
                                                      animator.SetBool("CorrectP", false);
                                                      animator.SetBool("False2V", false);
                                                      animator.SetBool("False1V", false);
                                                      animator.SetBool("False2D", false);
                                                      animator.SetBool("False1D", false);
                                                      animator.SetBool("False2P", false);
                                                      animator.SetBool("False1P", false);
                                                      animator.SetBool("False1G", false);
                                                      animator.SetBool("False2G", false);
                                                      animator.SetBool("AllP", false);
                                                      animator.SetBool("BothVD", false);
                                                      animator.SetBool("BothPV", false);
                                                      animator.SetBool("BothPD", false);
                                                      animator.SetBool("None", false);

                                                      } else if (GuiOnPlank == 5 && VocOnPlank == 1 && PiOnPlank == 5)
                                                      {
                                                        print("Vocal is on");
                                                        //drums_scriptgood.playDrums();

                                                        animator.SetBool("ActualDrum", false);
                                                        animator.SetBool("ActualGuitar", false);
                                                        animator.SetBool("ActualPiano", false);

                                                        animator.SetBool("CorrectV", true);

                                                        animator.SetBool("CorrectD", false);
                                                        animator.SetBool("CorrectG", false);
                                                        animator.SetBool("CorrectP", false);
                                                        animator.SetBool("False2V", false);
                                                        animator.SetBool("False1V", false);
                                                        animator.SetBool("False2D", false);
                                                        animator.SetBool("False1D", false);
                                                        animator.SetBool("False2P", false);
                                                        animator.SetBool("False1P", false);
                                                        animator.SetBool("False1G", false);
                                                        animator.SetBool("False2G", false);
                                                        animator.SetBool("AllP", false);
                                                        animator.SetBool("BothVD", false);
                                                        animator.SetBool("BothPV", false);
                                                        animator.SetBool("BothPD", false);
                                                        animator.SetBool("None", false);

                                                      } else if (DrumOnPlank == 0 && VocOnPlank == 0 && PiOnPlank == 0 && GuiOnPlank == 0)
                                                      {
                                                        print("none are on");
                                                        animator.SetBool("None", true);
                                                        animator.SetBool("CorrectD", false);
                                                        animator.SetBool("CorrectV", false);
                                                        animator.SetBool("CorrectP", false);
                                                        animator.SetBool("False2V", false);
                                                        animator.SetBool("False1V", false);
                                                        animator.SetBool("False2D", false);
                                                        animator.SetBool("False1D", false);
                                                        animator.SetBool("False2P", false);
                                                        animator.SetBool("False1P", false);
                                                        animator.SetBool("AllP", false);
                                                        animator.SetBool("BothVD", false);
                                                        animator.SetBool("BothPV", false);
                                                        animator.SetBool("BothPD", false);

                                                        } else if (DrumOnPlank == 0 && VocOnPlank == 0 && PiOnPlank == 0)
                                                        {
                                                          print("none are on");
                                                          animator.SetBool("None", true);
                                                          animator.SetBool("CorrectD", false);
                                                          animator.SetBool("CorrectV", false);
                                                          animator.SetBool("CorrectP", false);
                                                          animator.SetBool("False2V", false);
                                                          animator.SetBool("False1V", false);
                                                          animator.SetBool("False2D", false);
                                                          animator.SetBool("False1D", false);
                                                          animator.SetBool("False2P", false);
                                                          animator.SetBool("False1P", false);
                                                          animator.SetBool("AllP", false);
                                                          animator.SetBool("BothVD", false);
                                                          animator.SetBool("BothPV", false);
                                                          animator.SetBool("BothPD", false);

                                                          } else if (DrumOnPlank == 0 && VocOnPlank == 0)
                                                          {
                                                            print("none are on");
                                                            animator.SetBool("None", true);
                                                            animator.SetBool("CorrectD", false);
                                                            animator.SetBool("CorrectV", false);
                                                            animator.SetBool("CorrectP", false);
                                                            animator.SetBool("False2V", false);
                                                            animator.SetBool("False1V", false);
                                                            animator.SetBool("False2D", false);
                                                            animator.SetBool("False1D", false);
                                                            animator.SetBool("False2P", false);
                                                            animator.SetBool("False1P", false);
                                                            animator.SetBool("AllP", false);
                                                            animator.SetBool("BothVD", false);
                                                            animator.SetBool("BothPV", false);
                                                            animator.SetBool("BothPD", false);

                                                            } else if (VocOnPlank == 0)
                                                            {
                                                              print("none are on");
                                                              animator.SetBool("None", true);
                                                              animator.SetBool("CorrectD", false);
                                                              animator.SetBool("CorrectV", false);
                                                              animator.SetBool("CorrectP", false);
                                                              animator.SetBool("False2V", false);
                                                              animator.SetBool("False1V", false);
                                                              animator.SetBool("False2D", false);
                                                              animator.SetBool("False1D", false);
                                                              animator.SetBool("False2P", false);
                                                              animator.SetBool("False1P", false);
                                                              animator.SetBool("AllP", false);
                                                              animator.SetBool("BothVD", false);
                                                              animator.SetBool("BothPV", false);
                                                              animator.SetBool("BothPD", false);
                                                            }

                                                          }

                                                        }
