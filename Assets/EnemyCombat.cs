using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    [SerializeField] private Weapon currentWeapon;
 public EnemyCombat(Weapon currentWeapon)
    {
        this.currentWeapon = currentWeapon;
    }
    public void setWeapon(Weapon weapon)
    {
        currentWeapon = weapon;
    }
    public void attack()
    {
        if (currentWeapon != null)
        {
            currentWeapon.attack();
        }
    }
}
