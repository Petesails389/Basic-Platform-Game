using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] Collider2D groundDetectorCollider;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float acelleration;
    [SerializeField] float maxVelocity;
    [SerializeField] float jumpForce;
    [SerializeField] float drag;

    private bool isGrounded;

    void Update()
    {
        isGrounded = groundDetectorCollider.IsTouchingLayers(groundLayer);
        HorizontalDrag();
    }

    public void Move(float _direction)
    {
        if(rigidbody.velocity.x < maxVelocity && rigidbody.velocity.x > (maxVelocity * -1f)){
            rigidbody.AddForce(new Vector2(acelleration*_direction,0));
        }
    }

    public void Jump()
    {
        if(isGrounded){
            rigidbody.AddForce(new Vector2(0,jumpForce));
        }
    }

    void HorizontalDrag(){
        if (rigidbody.velocity.x != 0){
            rigidbody.velocity = new Vector2(rigidbody.velocity.x / drag, rigidbody.velocity.y);
        }
    }
}
