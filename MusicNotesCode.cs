using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicNotesCode : MonoBehaviour
{

  private Animator animator;

  public Vector3 PositionLevel;

  public AudioSource C_Notes;
  public AudioSource D_Notes;
  public AudioSource E_Notes;
  public AudioSource F_Notes;
  public AudioSource G_Notes;
  public AudioSource A_Notes;
  public AudioSource B_Notes;
  public AudioSource Cs_Notes;
  public AudioSource Ds_Notes;
  public AudioSource Fs_Notes;
  public AudioSource Gs_Notes;
  public AudioSource Bb_Notes;

  public GameObject Cnote;
  public GameObject C1note;
  public GameObject levelChecker;

  C_pressed Cscript;
  C1_pressed C1script;

  public List<int> NoteList;
  public List<int> CorrectList1a;
  public List<int> CorrectList1b;
  public List<int> CorrectList1c;
  public List<int> CorrectList1d;

  public List<int> CorrectList2a;
  public List<int> CorrectList2b;
  public List<int> CorrectList2c;
  public List<int> CorrectList2d;

  public int count;
  private bool wrong;
  public int scene = 1;
  public int worked = 0;

  void Start()
  {

    Cscript = Cnote.GetComponent<C_pressed>();
    C1script = C1note.GetComponent<C1_pressed>();

    //1 is high, 2 is low

    CorrectList1a.Add(2);
    CorrectList1a.Add(2);
    CorrectList1a.Add(1);
    CorrectList1a.Add(1);

    CorrectList1b.Add(1);
    CorrectList1b.Add(2);
    CorrectList1b.Add(1);
    CorrectList1b.Add(1);

    CorrectList1c.Add(1);
    CorrectList1c.Add(1);
    CorrectList1c.Add(1);
    CorrectList1c.Add(2);

    CorrectList1d.Add(2);
    CorrectList1d.Add(2);
    CorrectList1d.Add(2);
    CorrectList1d.Add(1);


    CorrectList2a.Add(1);
    CorrectList2a.Add(1);
    CorrectList2a.Add(2);
    CorrectList2a.Add(2);

    CorrectList2b.Add(2);
    CorrectList2b.Add(2);
    CorrectList2b.Add(1);
    CorrectList2b.Add(2);

    CorrectList2c.Add(1);
    CorrectList2c.Add(2);
    CorrectList2c.Add(2);
    CorrectList2c.Add(1);

    CorrectList2d.Add(2);
    CorrectList2d.Add(1);
    CorrectList2d.Add(1);
    CorrectList2d.Add(2);

  }

  void Update() {

    PositionLevel = GameObject.Find("levelchecker").transform.position;
  }

  public void scenes(int scene)
  {

    if (scene == 2)
    {
      print("scene change");
      SceneChange("lvl1b");

      } else if (scene == 3)
      {
        SceneChange("lvl1c");

        } else if (scene == 4)
        {
          SceneChange("lvl1d");

          } else if (scene == 5)
          {
            SceneChange("lvl2a");

            } else if (scene == 6)
            {
              SceneChange("lvl2b");

              } else if (scene == 7)
              {
                SceneChange("lvl2c");

                } else if (scene == 8)
                {
                  SceneChange("lvl2d");
                }
              }

              public void SceneChange(string scenename)
              {
                SceneManager.LoadScene(scenename);
              }

              private void Awake()
              {
                animator = GetComponent<Animator>();
              }

              public void Pressed(int pressed)
              {

                GameObject C1note  = GameObject.Find("C1");
                C1_pressed C1Script = C1note.GetComponent<C1_pressed>();


                if (pressed == 1)
                {
                  NoteList.Add(pressed);

                  } else if (pressed == 2)
                  {
                    NoteList.Add(pressed);
                  }

                }

                public void CheckLevel(List<int> correctlist, int scenenumb) {

                  animator.SetBool("welldone", false);
                  animator.SetBool("unlucky", false);
                  animator.SetBool("unlucky2", false);
                  animator.SetBool("unlucky3", false);
                  animator.SetBool("unlucky4", false);

                  animator.Play("SubmitKeys", 0, 0.1f);
                  wrong = false;

                  for (int k = 0; k < 4; k++) {

                    if(NoteList.Count < correctlist.Count) {
                      print("you entered fewer notes than on the sample sound, try again!");
                      wrong = true;
                      animator.SetBool("little", true);
                      animator.SetBool("many", false);
                      break;
                    }

                    if(NoteList.Count > correctlist.Count) {
                      print("you entered too many notes than on the sample sound, try again!");
                      wrong = true;
                      animator.SetBool("many", true);
                      animator.SetBool("little", false);
                      break;
                    }

                    if(NoteList[k] != correctlist[k]) {
                      print("You got key number " + k + " wrong, try again!");
                      wrong = true;
                      if (k == 0) {
                        print("first wrong");
                        animator.SetBool("unlucky", true);
                        animator.SetBool("unlucky2", false);
                        animator.SetBool("unlucky3", false);
                        animator.SetBool("unlucky4", false);

                      } else if (k == 1) {
                        print("second wrong");
                        animator.SetBool("unlucky", false);
                        animator.SetBool("unlucky2", true);
                        animator.SetBool("unlucky3", false);
                        animator.SetBool("unlucky4", false);

                      } else if (k == 2) {
                        print("third wrong");
                        animator.SetBool("unlucky", false);
                        animator.SetBool("unlucky2", false);
                        animator.SetBool("unlucky3", true);
                        animator.SetBool("unlucky4", false);

                      } else if (k == 3) {
                        print("fourth wrong");
                        animator.SetBool("unlucky", false);
                        animator.SetBool("unlucky2", false);
                        animator.SetBool("unlucky3", false);
                        animator.SetBool("unlucky4", true);

                      }
                      break;
                    }
                  }

                  if (wrong) {
                    NoteList.Clear();
                  }

                  if (!wrong) {
                    print("well done");
                    animator.SetBool("welldone", true);
                    animator.SetBool("unlucky", false);
                    animator.SetBool("unlucky2", false);
                    animator.SetBool("unlucky3", false);
                    animator.SetBool("unlucky4", false);
                    worked += 1;
                  }

                  if (worked == 2) {
                    //scene += 1;
                    scenes(scenenumb);
                  }
                }


                public void Check(int pressed)
                {

                  if ((PositionLevel[0] >= 337 && PositionLevel[0] <= 339)
                  && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                  && (PositionLevel[2] >= 92 && PositionLevel[2] <= 94))  {

                    print("level 1a");
                    CheckLevel(CorrectList1a, 2);//2 is level1b

                    } if ((PositionLevel[0] >= 336 && PositionLevel[0] <= 337)
                    && (PositionLevel[1] >= 4 && PositionLevel[1] <= 6)
                    && (PositionLevel[2] >= 96 && PositionLevel[2] <= 99))  {

                      print("level 1b");
                      CheckLevel(CorrectList1b, 3); //3 is level1c

                      } if ((PositionLevel[0] >= 336 && PositionLevel[0] <= 337)
                      && (PositionLevel[1] >= 4 && PositionLevel[1] <= 6)
                      && (PositionLevel[2] >= 109 && PositionLevel[2] <= 111))  {

                        print("level 1c");
                        CheckLevel(CorrectList1c, 4); //4 is level1d

                        } if ((PositionLevel[0] >= 335 && PositionLevel[0] <= 337)
                        && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                        && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123.5))  {

                          print("level 1d");
                          CheckLevel(CorrectList1d, 5); //5 is level2a

                          } if ((PositionLevel[0] >= 353 && PositionLevel[0] <= 355)
                          && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                          && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123.5))  {

                            print("level 2a");
                            CheckLevel(CorrectList2a, 6); //6 is level2b

                            } if ((PositionLevel[0] >= 359 && PositionLevel[0] <= 361)
                            && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                            && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123))  {

                              print("level 2b");
                              CheckLevel(CorrectList2b, 7); //7 is level2c

                              } if ((PositionLevel[0] >= 368 && PositionLevel[0] <= 370)
                              && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                              && (PositionLevel[2] >= 121 && PositionLevel[2] <= 123))  {

                                print("level 2c");
                                CheckLevel(CorrectList2c, 8); //8 is level2d

                                } if ((PositionLevel[0] >= 367 && PositionLevel[0] <= 369)
                                && (PositionLevel[1] >= 5 && PositionLevel[1] <= 7)
                                && (PositionLevel[2] >= 113 && PositionLevel[2] <= 115))  {

                                  print("level 2d");
                                  CheckLevel(CorrectList2d, 8); //9 is done

                                }
                              }

                              public void C_notes_play()
                              {
                                C_Notes.Play();
                                print("playing");
                              }

                              public void D_notes_play()
                              {
                                D_Notes.Play();
                              }

                              public void E_notes_play()
                              {
                                E_Notes.Play();
                              }

                              public void F_notes_play()
                              {
                                F_Notes.Play();
                              }

                              public void G_notes_play()
                              {
                                G_Notes.Play();
                              }

                              public void A_notes_play()
                              {
                                A_Notes.Play();
                              }

                              public void B_notes_play()
                              {
                                B_Notes.Play();
                              }

                              public void Cs_notes_play()
                              {
                                Cs_Notes.Play();
                              }

                              public void Ds_notes_play()
                              {
                                Ds_Notes.Play();
                              }

                              public void Fs_notes_play()
                              {
                                Fs_Notes.Play();
                              }

                              public void Gs_notes_play()
                              {
                                Gs_Notes.Play();
                              }

                              public void Bb_notes_play()
                              {
                                Bb_Notes.Play();
                              }
                            }
