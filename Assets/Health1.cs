using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health1 : MonoBehaviour
{
    public float health;
    public float healthmax;
    public float healthMin;
    // Start is called before the first frame update
    void Start()
    {
        health = healthmax;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= healthMin)
        {
            Destroy(gameObject);
        }
    }

    public void HealthDecrease()
    {
        health += -20;
    }
}
