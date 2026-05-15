using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Weapon currentWeapon;
    public PlayerCombat(Weapon weapon)
    {
        currentWeapon = weapon;
    }
    public void setWeapon(Weapon weapon)
    {
        currentWeapon = weapon;
    }
    public Weapon getWeapon()
    {
        return currentWeapon;
    }
    public void Attack()
    {
        if (getWeapon() == null)
        {
            Debug.Log("No weapon equipped!");
            return;
        }
        else if(getWeapon() !=null)
        {
            currentWeapon.Attack();
        }
    }
    public void AddBonusDamage(int amount, float duration)
    {
        StartCoroutine(BonusDamageCoroutine(amount, duration));
    }
    private IEnumerator BounusDamageCoroutine(int amount, float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    public void AddFireRateBoost(float amount, float duration)
    {
        StartCoroutine(FireRateCoroutine(amount, duration));
    }

    private IEnumerator FireRateCoroutine(float amount, float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
}

