using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRateItem : Item
{
    private float bonusFireRate;
    private float duration;
    public FireRateItem(string itemName, float bonusFireRate, float duration) : base(itemName)
    {
        this.bonusFireRate = bonusFireRate;
        this.duration = duration;
    }
    public void setBonusFireRate(float bonusFireRate)
    {
        this.bonusFireRate = bonusFireRate;
    }
    public void setDuration(float duration)
    {
        this.duration = duration;
    }
    public float getBonusFireRate()
    {
        return bonusFireRate;
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
