using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{
   private string weaponName;
    private int damage;
    private float fireRate;
    private int ammo;
    public WeaponData(string weaponName, int damage, float fireRate, int ammo)
    {
        this.weaponName = weaponName;
        this.damage = damage;
        this.fireRate = fireRate;
        this.ammo = ammo;
    }
}
