using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField] float totalFuel;
    [SerializeField] Transform timerForeground;
    [SerializeField] bool isMoving = false;

    private float fuel;

    void Start()
    {
        this.fuel = totalFuel;
    }
    
    
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0){
            fuel -= Time.deltaTime;
            timerForeground.localScale = new Vector3(fuel/totalFuel,1f,0);
        }
        if (fuel <= 0){
            print("quit");
            Application.Quit();
        }
    }
}