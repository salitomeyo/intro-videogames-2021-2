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
    private GunController _gunController;

    private Camera _cam;
    private Plane _worldPlane;
    
    private Vector2 _movementInput;
    private Quaternion _targetRotation;
    private bool _isShooting;

    void Start()
    {
        _movementController = GetComponent<PlayerMovementController>();
        _gunController = GetComponent<GunController>();
        _cam = Camera.main;
        _worldPlane = new Plane(Vector3.up, 0);
    }
    
    void Update()
    {
        ProcessInputs();
        
        //Movement
        Vector3 targetMovementDirection = new Vector3(_movementInput.x, 0, _movementInput.y);
        targetMovementDirection.Normalize();
        
        //Rotation: look at movement direction
        //_targetRotation = Quaternion.LookRotation(targetMovementDirection);
        _movementController.Move( targetMovementDirection * _speed );
        _movementController.RotateTo( _targetRotation, _rotationSpeed );

        if (_isShooting)
        {
            _gunController.OnTriggerHold();
        }
        else
        {
            _gunController.OnTriggerRelease();
        }
    }

    void ProcessInputs()
    {
        _movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Process rotation
        CalculateTargetRotation();
        
        //Shoot
        _isShooting = Input.GetButton("Fire1");
    }

    void CalculateTargetRotation()
    {
        //We made a raycast to detect where the mouse is in our 3D space
        Vector2 mouseScreenPosition = Input.mousePosition;
        
        //Create the Ray. In this case we use the camera cause we need to convert the 
        //  mouse position (Screen coordinates) to a 3D point (World space).
        Ray ray = _cam.ScreenPointToRay(mouseScreenPosition);
        
        
        //Process Raycast using the Physics engine
        //   Will contain all the info result from the raycast hit.
        //   Check https://docs.unity3d.com/ScriptReference/RaycastHit.html for more info.
        //RaycastHit hit; 
        // if (Physics.Raycast(ray, out hit))
        // {
        //     Vector3 dir = (hit.point - transform.position).normalized;
        //     _targetRotation = Quaternion.LookRotation(dir);
        // }

        float distanceToPlane;
        if (_worldPlane.Raycast(ray, out distanceToPlane))
        {
            Vector3 pointHit = ray.GetPoint(distanceToPlane);
            Vector3 dir = (pointHit - transform.position).normalized;
            _targetRotation = Quaternion.LookRotation(dir);
        }
    }
}
