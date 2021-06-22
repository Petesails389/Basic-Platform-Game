using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] Collider2D groundDetectorCollider;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float maxVelocity;
    [SerializeField] float jumpForce;

    private bool isGrounded;

    void Update()
    {
        isGrounded = groundDetectorCollider.IsTouchingLayers(groundLayer);
    }

    public void Move(float _direction)
    {
        rigidbody.velocity = new Vector2(maxVelocity*_direction, rigidbody.velocity.y);
    }

    public void Jump()
    {
        if(isGrounded){
            rigidbody.AddForce(new Vector2(0,jumpForce));
        }
    }
}
