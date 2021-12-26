using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Transform _focalTransform;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _movespeed;
    private float _verticalInput;

    void FixedUpdate()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _rigidBody.AddForce(_focalTransform.forward * _movespeed * _verticalInput);
    }
}
