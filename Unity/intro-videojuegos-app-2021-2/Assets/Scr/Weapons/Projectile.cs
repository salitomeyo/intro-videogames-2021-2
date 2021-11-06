using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10;
    [SerializeField]
    private float _lifetime = 3;

    private float _timeToDisable = 3;
    
    private void Start()
    {
        _timeToDisable = _lifetime;
    }

    private void Update()
    {
        if (_timeToDisable <= 0)
        {
            Destroy(gameObject);
            return;
        }

        _timeToDisable -= Time.deltaTime;
        
        float movementDistance = _speed * Time.deltaTime; //X = V * T
        Vector3 translation = Vector3.forward * movementDistance;
        transform.Translate(translation);
    }
}
