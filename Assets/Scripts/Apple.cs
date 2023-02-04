using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    
    public bool CanSpawn;
    public float MaxRange;
    private void Start()
    {
        StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {
        while (CanSpawn)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, MaxRange));
            yield return StartCoroutine(SpawnApples());
        }
    }

    public IEnumerator SpawnApples()
    {

        return null;

    }

}
