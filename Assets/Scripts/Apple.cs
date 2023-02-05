using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject Explosion;

    public GameObject Player;
    private HealthComponent _healthComponent;
    // Start is called before the first frame update
    private void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }

    
    private void OnCollisionEnter(Collision other)
    {
        _healthComponent.CurrentHealth = _healthComponent.CurrentHealth + 10;
        Destroy((gameObject));
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Explosion,transform.position,Quaternion.identity);
         Destroy(gameObject);
    }
}
