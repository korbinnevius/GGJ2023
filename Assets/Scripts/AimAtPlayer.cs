using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAtPlayer : MonoBehaviour
{
  public Transform Player;

  public void Update()
  {
    Vector3 PLayerLocation = Player.position - transform.position;
    Quaternion.LookRotation(PLayerLocation,Vector3.up);
  }
}
