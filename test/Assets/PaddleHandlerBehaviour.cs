using System;
using UnityEngine;

public class PaddleHandlerBehaviour : MonoBehaviour
{
    public Rigidbody rb { get; private set; }
    
    public Vector2 direction { get; private set; }

    public float speed = 30f;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.direction = Vector2.left;
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            this.direction = Vector2.right;
        }

        else
        {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.direction != Vector2.zero)
        {
            this.rb.AddForce(this.direction * this.speed);
        }
    }
}