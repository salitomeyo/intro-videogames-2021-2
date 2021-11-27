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

    [Header("Testing...")]
    public LayerMask maskCollision;
    
    private void Start()
    {
        _timeToDisable = _lifetime;
        CheckInitialCollision();
    }

    private void Update()
    {
        if (_timeToDisable <= 0)
        {
            DestroyProjectile();
            return;
        }

        _timeToDisable -= Time.deltaTime;
        
        float movementDistance = _speed * Time.deltaTime; //X = V * T
        Vector3 translation = Vector3.forward * movementDistance;
        CheckCollision(translation);
        transform.Translate(translation);
    }

    private void CheckInitialCollision()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0.25f, maskCollision);
        foreach (Collider hitCollider in hitColliders)
        {
            Debug.LogError("Initial collision with: " + hitCollider.name);
            
            if (hitCollider.transform.TryGetComponent<IDamageable>(out IDamageable target))
            {
                target.TakeHit(1, transform.position, transform.forward);
            }
            
            DestroyProjectile();
        }
    }

    private void CheckCollision(Vector3 translation)
    {
        RaycastHit hit; 
        if (Physics.Raycast(transform.position, transform.forward, out hit, translation.magnitude, maskCollision))
        {
            if (hit.transform.TryGetComponent<IDamageable>(out IDamageable target))
            {
                target.TakeHit(1, hit.point, hit.normal);
            }
            
            DestroyProjectile();
        }
    }

    private void DestroyProjectile()
    {
        Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
