using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool HasPowerup { get; private set; }
    private Rigidbody _enemyRigidbody;
    private Vector3 _awayFromPlayer;
    private float _pushStrenght;
    [SerializeField] GameObject _powerupIndicator;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            HasPowerup = true;
            Destroy(other.gameObject);
            _powerupIndicator.SetActive(true);
            _pushStrenght = Powerup.Power;
            StartCoroutine(PowerupCountdown());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && HasPowerup)
        {
            _enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            _awayFromPlayer = collision.gameObject.transform.position - transform.position;
            _enemyRigidbody.AddForce(_awayFromPlayer * _pushStrenght);
        }
    }

    IEnumerator PowerupCountdown()
    {
        yield return new WaitForSeconds(5);
        _powerupIndicator.SetActive(false);
        HasPowerup = false;
    }
}
