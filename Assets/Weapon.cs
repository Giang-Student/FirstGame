using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string weaponName;
    [SerializeField] private int damage;
    [SerializeField] private float fireRate;
    public Weapon (string weaponName, int damage,
     float fireRate)
    {
        this.weaponName = weaponName;
        this.damage = damage;
        this.fireRate = fireRate;
    }
    public void setWeaponName(string weaponName)
    {
        this.weaponName = weaponName;
    }
    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public void setFireRate(float fireRate)
    {
        this.fireRate = fireRate;
    }
    public string getWeaponName()
    {
        return weaponName;
    }
    public int getDamage()
    {
        return damage;
    }
    public float getFireRate()
    {
        return fireRate;
    }
    public abstract void attack();
}
