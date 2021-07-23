using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSController : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;

    private bool state = false;

    public void ToggleState()
    {
        var psMain = ps.emission;
        if(state){
            state = false;
            psMain.rateOverDistance = 0;
        }
        else{
            state = true;
            psMain.rateOverDistance = 5;
        }
    }
}
