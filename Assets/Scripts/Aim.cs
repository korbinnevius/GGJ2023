using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        Vector3 PLayerLocation = Player.position - transform.position;
        Quaternion.LookRotation(PLayerLocation,Vector3.up);
    }
}
