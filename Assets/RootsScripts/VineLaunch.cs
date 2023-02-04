using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class VineLaunch : MonoBehaviour
{
    public Transform Player;
    public Transform Base;
    public float Speed;
    public float MaxRange;
    public bool CanShoot;

    private void Start()
    {
        
        StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {
        while (CanShoot)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, MaxRange));
            yield return StartCoroutine(Shoot());
        }
    }
    public IEnumerator Shoot()
    {
        GetComponent<Aim>().enabled = false;
        Vector3 newpos = Player.position;
        float distance = Vector3.Distance(transform.position, newpos);
        Vector3 start = transform.position;
        if (distance > 0.25f)
        {
            float t = 0;
            while (t < 3)
            {
                transform.position = Vector3.Lerp(start, newpos, t);
                t = t + (Time.deltaTime / distance) * Speed;
                yield return null;
            }
            t = 0;
            while (t < 3)
            {
                transform.position = Vector3.Lerp(newpos, Base.position, t);
                t = t + (Time.deltaTime / distance) * Speed;
                yield return null;
            }
            GetComponent<Aim>().enabled = true;
        }
    }

    // private void OnTriggerEnter(Collider other)
    // { 
    //     Vector3 newpos = Player.position;
    //     float distance = Vector3.Distance(transform.position, newpos);
    //     float t = 0;
    //     t = 0;
    //     while (t < 3)
    //     {
    //         transform.position = Vector3.Lerp(transform.position, Base.position, t);
    //         t = t + (Time.deltaTime / distance) * Speed;
    //    
    //     }
    // }
}
