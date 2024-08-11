using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Animator _anim;

    public float speed = 5f;
    public float turnSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.enabled == false)
        {
            controller.enabled = true;
            return;
        }

        if (_anim.GetBool("isAttacking") == false)
        {
            Vector3 movDir;

            _anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
            _anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

            transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            movDir = transform.forward * Input.GetAxis("Vertical") * speed;

            controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);
        }
    }
}
