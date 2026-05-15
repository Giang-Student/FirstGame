using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon
{
    [SerializeField] private float range;
    public MeleeWeapon(string weaponName, int damage, float fireRate,
     float range) : base(weaponName, damage, fireRate)
    {
        this.range = range;
    }
    public void setRange(float range)
    {
        this.range = range;
    }
    public float getRange()
    {
        return range;
    }
    public override void attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, range);

        foreach (Collider2D hit in hits)
        {
            IDamageable target = hit.GetComponent<IDamageable>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
