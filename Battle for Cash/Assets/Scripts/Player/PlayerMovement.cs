using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public PhotonView photonview;

    private VariableJoystick joystick;
    public Rigidbody rbPlayer;

    public float playerspeed, forcejump;

    public bool isGround;

    Vector3 direction, rotate;
    void Start()
    {
        joystick = GameObject.Find("Variable Joystick").GetComponent<VariableJoystick>();
        rbPlayer = GetComponent<Rigidbody>();
        photonview = GetComponent<PhotonView>();

    }

    void Update()
    {
        if (photonview.IsMine)
        {
            MoveMobile();
            Rotation();
        }
    }

    void MoveMobile()
    {
        direction = (Vector3.forward * joystick.Vertical) + (Vector3.right * joystick.Horizontal);
    }
    void Rotation()
    {
        if(direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
        transform.Translate(direction * (playerspeed * Time.deltaTime), Space.World);
    }

    public void Jump()
    {
        if (isGround)
        {
            rbPlayer.AddForce(Vector3.up * forcejump, ForceMode.Impulse);
            isGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
