using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPoint : MonoBehaviour
{
    private GameObject timer;
    [SerializeField] float fuelAmount;
    TimerScript timerScript;

    void Start()
    {
        timer = GameObject.Find("Timer");
        timerScript = timer.GetComponent(typeof(TimerScript)) as TimerScript;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        timerScript.Fuel(fuelAmount);
        GameObject.Destroy(gameObject);
    }
}
