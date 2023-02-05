using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Apple : MonoBehaviour
{
    public GameObject apple;
    public GameObject explosion;
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

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-110, -160), Random.Range(80, 50), 238);
            Instantiate(apple, randomSpawnPosition, quaternion.identity);
            yield return new WaitForSeconds(5);
            yield return StartCoroutine(Appleexplode());
    }

    public IEnumerator Appleexplode()
    {
        
        Instantiate(explosion,transform.position,quaternion.identity);
        DestroyImmediate(apple,true);
        DestroyImmediate(explosion,true);
        yield return null;
    }
}
