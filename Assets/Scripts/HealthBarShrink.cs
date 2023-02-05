using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarShrink : MonoBehaviour
{
    public RectTransform healthBar;


    private void Awake()
    {
        healthBar = GetComponent<RectTransform>();
    }

    private void HealthBarShrinkWidth()
    {
        healthBar.sizeDelta = new Vector2 (100/10f, 100);
    }
}
