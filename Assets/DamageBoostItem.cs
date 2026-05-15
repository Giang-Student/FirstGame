using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBoostItem : Item
{
    [SerializeField] private int bonusDamage;
    [SerializeField] private float duration;
    public DamageBoostItem(string itemName, int bonusDamage, float duration) : base(itemName)
    {
        this.bonusDamage = bonusDamage;
        this.duration = duration;
    }
    public void setBonusDamage(int bonusDamage)
    {
        this.bonusDamage = bonusDamage;
    }
    public void setDuration(float duration)
    {
        this.duration = duration;
    }
    public int getBonusDamage()
    {
        return bonusDamage;
    }
    public float getDuration()
    {
        return duration;
    }
    public override void use(Player player)
    {
        PlayerCombat combat = player.GetComponent<PlayerCombat>();
        if(combat != null)
        {
            combat.AddBonusDamage(getBonusDamage(), getDuration());   
        }
    }
}
