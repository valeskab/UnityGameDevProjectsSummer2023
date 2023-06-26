using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandlerBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D currentBallRigidBody;
    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
    }
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            currentBallRigidBody.isKinematic = false;
            return;
        }
        
        currentBallRigidBody.isKinematic = true;
        
        Vector2 touchPosition =Touchscreen.current.primaryTouch.position.ReadValue();

        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);

        currentBallRigidBody.position = worldPosition;
        
    }
}
