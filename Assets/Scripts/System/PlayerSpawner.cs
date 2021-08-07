using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform spawnPoint;
    
    void Start()
    {
        this.Respawn();
    }
    public void Respawn()
    {
        Player.position = spawnPoint.position;
    }
}
