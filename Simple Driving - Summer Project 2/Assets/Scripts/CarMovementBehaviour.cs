using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.2f;
    
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Rotate(0f, 1f * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
    }
}
