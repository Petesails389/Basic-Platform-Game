using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] Animator animator;
    [SerializeField] new Transform transform;

    void Update()
    {
        playerMovement.Move(Input.GetAxis("Horizontal"));//physics

        if (Input.GetKeyDown("w") | Input.GetKeyDown(KeyCode.UpArrow)){
            playerMovement.Jump();//physics
            animator.SetBool("IsJumping",true);//animation
        }

        //animation stuff
        animator.SetFloat("Speed",Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetAxis("Horizontal") > 0){
            transform.localScale = new Vector3(1,1,1);
        }
        else if (Input.GetAxis("Horizontal") < 0){
            transform.localScale = new Vector3(-1,1,1);
        }
    }
    public void OnLand()
    {
        animator.SetBool("IsJumping",false);
    }
}
