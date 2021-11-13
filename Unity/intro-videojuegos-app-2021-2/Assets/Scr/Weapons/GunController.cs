using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [Header("Testing...")]
    public Gun _currentGun; //Equipped gun

    public void OnTriggerHold()
    {
        _currentGun.OnTriggerHold();
    }
    
    public void OnTriggerRelease()
    {
        _currentGun.OnTriggerRelease();
    }
}
