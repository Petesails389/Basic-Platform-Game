using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] new Transform camera;

    private float newCameraY;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        camera = GameObject.FindWithTag("MainCamera").transform;
        newCameraY = 0;
    }

    void Update()
    {
        if(player.position.y > 0){
            newCameraY = player.position.y;
        }
        camera.position = new Vector3(player.position.x,newCameraY,-10f);
    }
}
