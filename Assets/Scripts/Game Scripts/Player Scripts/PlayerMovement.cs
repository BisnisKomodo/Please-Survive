using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationspeed;
    private Rigidbody2D rb2d;
    private Vector2 moveinput;
    private Vector2 SmoothMoveInput;
    private Vector2 movementInputSmoothVelocity;
    private Animator animator;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateInDirectionInput();
        SetAnimation();
    }

    private void SetAnimation()
    {
        bool isMoving = moveinput != Vector2.zero;

        animator.SetBool("IsMoving", isMoving);
    }

    private void SetPlayerVelocity()
    {
        SmoothMoveInput = Vector2.SmoothDamp(SmoothMoveInput, moveinput, ref movementInputSmoothVelocity, 0.1f);
        rb2d.velocity = SmoothMoveInput * speed;
    }

    private void RotateInDirectionInput()
    {
        if (moveinput != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, SmoothMoveInput);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationspeed * Time.deltaTime);

            rb2d.MoveRotation(rotation); 
        }
    }

    private void OnMove(InputValue inputValue)
    {
       moveinput = inputValue.Get<Vector2>();
    }
}
