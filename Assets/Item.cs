using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected string itemName;
    public Item(string itemName)
    {
        this.itemName = itemName;
    }
    public void setItemName(string itemName)
    {
        this.itemName = itemName;
    }
    public string getItemName()
    {
        return itemName;
    }
    public abstract void use(Player player);
    // Start is called before the first frame update

}
