using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleSpawner : MonoBehaviour
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

        Vector3 randomSpawnPosition = new Vector3(Random.Range(13, -6), Random.Range(3, -3), -.1f);
            Instantiate(apple, randomSpawnPosition, Quaternion.identity);
            yield return null;
    }
}
