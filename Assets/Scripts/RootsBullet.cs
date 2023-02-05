using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootsBullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Debug.Log("Destroy");
    }

    public void Fire(Vector3 firePointForward, float fireVelocity)
    {
        _rigidbody.AddForce(firePointForward * fireVelocity, ForceMode.Impulse);
        Debug.Log("shoot");
    }
}
