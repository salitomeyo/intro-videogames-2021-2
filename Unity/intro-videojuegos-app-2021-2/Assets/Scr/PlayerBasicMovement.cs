using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _maxSpeed = 5f;
    [SerializeField]
    private float _acceleration = 15f;
    [SerializeField]
    private float _deceleration = 15f;
    
    
    private float _currentSpeed = 0.1f;
    private Vector3 lastMovementDirection;
    
    void Update()
    {
        //What's the difference if we use Input.GetAxisRaw instead?
        //   Use the console to check the difference: Debug.Log or Debug.LogError
        //Which one should we use? (GetAxis or GetAxisRaw)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(horizontal, 0, vertical);

        //What does .magnitude? (Search for Unity Vector magnitude). Why it's useful?
        if (input.magnitude > 0)
        {
            _currentSpeed += _acceleration * Time.deltaTime;
            
            //TODO: Normalize the input to get the direction
            //What means to normalize a Vector? And why it's useful when we apply movement?
            lastMovementDirection = input;
        }
        else
        {
            _currentSpeed -= _deceleration * Time.deltaTime;
        }

        //https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
        _currentSpeed = Mathf.Clamp(_currentSpeed, 0f, _maxSpeed);
        
        Vector3 velocity = lastMovementDirection * _currentSpeed;
        Vector3 movement = velocity * Time.deltaTime;
        
        transform.position += movement;
    }
    
}
