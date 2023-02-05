using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Input = UnityEngine.Windows.Input;

public class RootsShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference shoot;
    
    // [SerializeField] private Transform firePoint;
    // [SerializeField] private GameObject bulletPrefab;
    // private Vector2 lookDirection;
    // private float lookingAngle;
    //
    //
    // private void Update()
    // {
    //     lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    //     lookingAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
    //     transform.rotation = Quaternion.Euler(0f, 0f, lookingAngle - 90f);
    //
    //     if (playerController.MouseEnabled)
    //     {
    //         
    //     }
    // }

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireVelocity = 30f;

    private void Update()
    {
        //Fire();
    }

    public void Fire()
    {
        Debug.Log("Fire");
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(firePoint.right * fireVelocity, ForceMode.Impulse);
    }
}
