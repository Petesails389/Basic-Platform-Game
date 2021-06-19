using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;

    void Update()
    {
        playerMovement.Move(Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown("w") | Input.GetKeyDown(KeyCode.UpArrow)){
            playerMovement.Jump();
        }
    }
}
