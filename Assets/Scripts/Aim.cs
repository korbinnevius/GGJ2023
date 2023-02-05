using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform Player;
    public float DistanceToTarget => Vector3.Distance(transform.position,Player.position);
    void Update()
    {
       // transform.LookAt(Player, Vector3.up);
       Vector3 PLayerLocation = (Player.position - transform.position).normalized;
     // Quaternion lookRotation =  Quaternion.LookRotation(Vector3.right,PLayerLocation);
      Quaternion lookRotation =  Quaternion.LookRotation(PLayerLocation,Vector3.up);
     //transform.rotation = Quaternion.Euler(0,0, lookRotation.eulerAngles.z+ 90);
     transform.rotation = lookRotation * Quaternion.Euler(0,-90,0);
     
    }
}
