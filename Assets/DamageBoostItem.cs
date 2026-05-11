using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBoostItem : Item
{
    private int bonusDamage;
    private float duration;
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
