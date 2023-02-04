using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        Vector3 PLayerLocation = (Player.position - transform.position).normalized;
      Quaternion lookRotation =  Quaternion.LookRotation(Vector3.forward,PLayerLocation);
      transform.rotation = Quaternion.Euler(0,0, lookRotation.eulerAngles.z + 90);
    }
}
