using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfIslandDestroyer : MonoBehaviour
{
    private float _yBound = -10;

    void Update()
    {
        if(transform.position.y < _yBound)
        {
            Destroy(gameObject);
        }
    }
}
