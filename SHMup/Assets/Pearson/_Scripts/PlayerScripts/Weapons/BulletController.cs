using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    Rigidbody RB;
    public float speed;
    public float lifetime;
    public float damageAmount;
	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;

        RB.velocity = (transform.forward * speed);
        Destroy(gameObject,lifetime);
        
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<Idamageable>().TakeDamage(damageAmount);
        }
        if (!other.CompareTag("bullet") && !other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
