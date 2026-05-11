using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private string weaponName;
    private int damage;
    private float fireRate;
    private int ammo;
    private Bullet bullet;
    public Weapon (string weaponName, int damage,
     float fireRate, int ammo, Bullet bullet)
    {
        this.weaponName = weaponName;
        this.damage = damage;
        this.fireRate = fireRate;
        this.ammo = ammo;
        this.bullet = bullet;
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
    public void setAmmo(int ammo)
    {
        this.ammo = ammo;
    }
    public void setBulletPrefab(Bullet bullet)
    {
        this.bullet = bullet;
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
    public int getAmmo()
    {
        return ammo;
    }
    public Bullet getBulletPrefab()
    {
        return bullet;
    }
    public void shoot()
    {
        
    }
    public void reload()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
