using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Apple : MonoBehaviour
{
    public GameObject apple;
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

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-110, -160), Random.Range(80, 50), 235);
            Instantiate(apple, randomSpawnPosition, quaternion.identity);
            return null;
    }
    
}
