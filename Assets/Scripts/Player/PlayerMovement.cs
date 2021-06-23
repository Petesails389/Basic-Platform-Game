using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] Collider2D groundDetectorCollider;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float maxVelocity;
    [SerializeField] float jumpForce;

	[SerializeField] UnityEvent OnLandEvent;

    private bool isGrounded;
    private bool wasGrounded;

    void Update()
    {
        wasGrounded = isGrounded;
        isGrounded = groundDetectorCollider.IsTouchingLayers(groundLayer);

        if (!wasGrounded && isGrounded){
            OnLandEvent.Invoke();
        }
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
