using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    private HealthComponent _healthComponent;
    public RootsGameManager _rootsGameManager;

    private void Awake()
    {
        _rootsGameManager = GetComponent<RootsGameManager>();
        _healthComponent = GetComponent<HealthComponent>();
    }

    private void OnCollisionEnter(Collision other)
    {
        _healthComponent.CurrentHealth = _healthComponent.CurrentHealth - 10;
    }
}
