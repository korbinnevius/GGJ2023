using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject Explosion;

    public GameObject Player;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision Player)
    {
        
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Explosion,transform.position,Quaternion.identity);
         Destroy(gameObject);
        
    }
    
    

}
