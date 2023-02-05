using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public RootsGameManager rootsGM;
    [SerializeField] private HealthComponent bossHealth;
    //[SerializeField] private HealthComponent playerHealth;

    private void Awake()
    {
        //playerHealth = GetComponent<HealthComponent>();
    }

    private void Update()
    {
        BossIsDead();
    }

    private void BossIsDead()
    {
        if (bossHealth.CurrentHealth <= 0)
        {
            rootsGM.CompleteLevel();
        }
    }
    
    // private void PlayerIsDead()
    // {
    //     if (playerHealth.CurrentHealth <= 0)
    //     {
    //         rootsGM.CompleteLevel();
    //     }
    // }
}
