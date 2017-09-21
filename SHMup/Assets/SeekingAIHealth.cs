using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingAIHealth : MonoBehaviour, Ikillable, Idamageable {


    public float health;
    private float MaxHealth;


    public void Die()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float DamageTaken)
    {
        health -= DamageTaken;
    }



	// Use this for initialization
	void Start ()
    {
        MaxHealth = health;
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}
}
