using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEat : MonoBehaviour
{
    
    private HealthComponent _healthComponent;
    // Start is called before the first frame update
    private void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
