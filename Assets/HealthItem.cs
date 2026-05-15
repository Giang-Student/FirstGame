using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : Item
{
    [SerializeField] private int healAmount;
    public HealthItem(string itemName, int healAmount) : base(itemName)
    {
        this.healAmount = healAmount;
    }
    public void setHealAmount(int healAmount)
    {
        this.healAmount = healAmount;
    }
    public int getHealAmount()
    {
        return healAmount;
    }
    public override void use(Player player)
    {
        player.TakeDamage(- getHealAmount());
    }
}
