using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform _playerTranform;
    [SerializeField] private float _movespeed = 2.0f;
    [SerializeField] private Rigidbody _rigidBody;
    private Vector3 movingDirection;

    private void FixedUpdate()
    {   
        movingDirection = (_playerTranform.position - transform.position).normalized;
        _rigidBody.AddForce(movingDirection * _movespeed);
    }

    public void SetPlayerTransform(Transform player)
    {
        _playerTranform = player;
    }
}
