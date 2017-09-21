using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawn : MonoBehaviour {
    public float minspawn, maxspawn;
    public float minrange, maxrange;
    float spawntime;
    int gun;
    GameObject shotgun, laser, aids;
	// Use this for initialization
	void Start () {
        spawntime = Random.Range(minspawn, maxspawn);
	}
	
	// Update is called once per frame
	void Update () {

        spawntime -= Time.deltaTime;

        if(spawntime <= 0)
        {
            gun = Random.Range(1, 3);

            switch(gun)
            {
                //case 1:
                //    Instantiate(shotgun,);
            }
        }

	}
}
