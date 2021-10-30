using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    [SerializeField]
    private float _rotationSpeed = 30f;
    
    private PlayerMovementController _movementController;

    private Camera _cam;
    
    private Vector2 _movementInput;
    private Quaternion _targetRotation;

    void Start()
    {
        _movementController = GetComponent<PlayerMovementController>();
        _cam = Camera.main;
    }
    
    void Update()
    {
        ProcessInputs();
        
        //Movement
        Vector3 targetMovementDirection = new Vector3(_movementInput.x, 0, _movementInput.y);
        targetMovementDirection.Normalize();
        _movementController.Move( targetMovementDirection * _speed );
        //_targetRotation = Quaternion.LookRotation(targetMovementDirection);
        _movementController.RotateTo( _targetRotation, _rotationSpeed );
    }

    void ProcessInputs()
    {
        _movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Rotation
        //Shoot?

        CalculateTargetRotation();
    }

    void CalculateTargetRotation()
    {
        Vector2 mouseScreenPosition = Input.mousePosition;
        RaycastHit hit;
        Ray ray = _cam.ScreenPointToRay(mouseScreenPosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 dir = (hit.point - transform.position).normalized;
            _targetRotation = Quaternion.LookRotation(dir);
        }
    }
}
