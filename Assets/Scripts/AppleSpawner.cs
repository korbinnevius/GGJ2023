using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleSpawner : MonoBehaviour
{
    public GameObject apple;
    public bool CanSpawn;
    public float MaxRange;
    public int Rota;
   
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

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-23, 23),0.1f, Random.Range(8,-12));
            Instantiate(apple, randomSpawnPosition, apple.transform.rotation);
            yield return null;
    }
}
