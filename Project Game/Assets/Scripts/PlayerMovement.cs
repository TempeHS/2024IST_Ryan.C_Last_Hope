using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
private float moveSpeed = 5f;
public Rigidbody2D rb;
public Animator animator;
Vector2 movement;

void Update()
{
movement.x = Input.GetAxisRaw("Horizontal");
movement.y = Input.GetAxisRaw("Vertical");
animator.SetFloat("Horizontal", movement.x);
animator.SetFloat("Vertical", movement.y);
animator.SetFloat("Speed", movement.magnitude);
}

void FixedUpdate()
{
rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
}
}
