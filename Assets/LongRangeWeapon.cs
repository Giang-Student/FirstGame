using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongRangeWeapon : Weapon
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int ammo;

    public LongRangeWeapon(string weaponName, int damage, float fireRate,
     Bullet bulletPrefab, Transform firePoint, int ammo) : base(weaponName, damage, fireRate)
    {
        this.bulletPrefab = bulletPrefab;
        this.firePoint = firePoint;
        this.ammo = ammo;
    }
    public void setBulletPrefab(Bullet bulletPrefab)
    {
        this.bulletPrefab = bulletPrefab;
    }
    public void setFirePoint(Transform firePoint)
    {
        this.firePoint = firePoint;
    }
    public void setAmmo(int ammo)
    {
        this.ammo = ammo;
    }
    public Bullet getBulletPrefab()
    {
        return bulletPrefab;
    }
    public Transform getFirePoint()
    {
        return firePoint;
    }
    public int getAmmo()
    {
        return ammo;
    }
    public override void attack()
    {
    //     if (ammo <= 0)
    //         return;

    //     Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    //     ammo--;
    }
    public void reload(int ammo)
    {
        // this.ammo += ammo;
    }
}
