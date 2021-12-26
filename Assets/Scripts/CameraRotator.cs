using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed;
    private float _horizontalInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * _rotationSpeed * _horizontalInput * Time.deltaTime); 
    }
}
