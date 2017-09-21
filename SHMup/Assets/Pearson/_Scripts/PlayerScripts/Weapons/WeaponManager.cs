using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    public int DesiredWeapon;

    public GameObject bullets;
    public Transform[] Pos; //shoot position
    float cooldown;
    int gun;
    float dt;
    // Use this for initialization
    void Start () {
        gun = DesiredWeapon;
	}
	

    void shotgun()
    {
        cooldown -= dt;
        if (cooldown <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(bullets, Pos[i].position, Pos[i].rotation);
            }
            cooldown = .1f;
        }
    }

    void Pistol()
    {
        cooldown -= dt;
        if (cooldown <= 0)
        {
            GameObject bullet = Instantiate(bullets, Pos[0].position, Pos[0].rotation);
            cooldown = .1f;
        }
    }

    float fire;
    void InputManager()
    {
        fire = Input.GetAxis("Fire1");
    }
    public float weaponTime;
	// Update is called once per frame
	void Update ()
    {
        gun = DesiredWeapon;
        if (weaponTime <= 0)
        {
            gun = 0;
        }
        dt = Time.deltaTime;

        weaponTime -= dt;
        InputManager();
        if (fire != 0)
        {
            switch (gun)
            {
                case 0:
                    Pistol();
                    break;
                case 1:
                    shotgun();
                    break;

            }
        } 
	}
    
}
