using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public CharacterController controller;

  public float speed = 12f;
  public float gravity = -50f;
  public float jumpHeight = 1.5f;

  public Vector3 PlayerPosition;

  public GameObject vocal;
  public GameObject piano;
  public GameObject drums;
  public GameObject guitar;

  Vocal vocal_script;
  Piano piano_script;
  Drums drums_script;
  Guitar guitar_script;

  public Transform groundCheck;
  public Transform buttonCheck;

  public float groundDistance = 0.4f;

  public LayerMask groundMask;
  public LayerMask buttonMask;

  Vector3 velocity;

  bool isGrounded;
  bool isButton;
  bool isDoor;

  public int count = 0;
  public int level = 1;

  void Start()
  {
    vocal_script = vocal.GetComponent<Vocal>();
    piano_script = piano.GetComponent<Piano>();
    drums_script = drums.GetComponent<Drums>();
    guitar_script = guitar.GetComponent<Guitar>();

    PlayerPosition = GameObject.Find("Body").transform.position;

  }

  void Update()
  {
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
    isButton = Physics.CheckSphere(buttonCheck.position, groundDistance, buttonMask);


    if (isGrounded && velocity.y < 0)
    {
      velocity.y = -2f;
    }

      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");

      Vector3 move = transform.right * x + transform.forward * z;

      controller.Move(move  *  speed * Time.deltaTime);

      if (Input.GetButtonDown("Jump") && isGrounded)
      {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
      }

      velocity.y += gravity * Time.deltaTime;

      controller.Move(velocity * Time.deltaTime);

    }
  }
