using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items;
    public Inventory(List<Item> items)
    {
        this.items = items;
    }
    public List<Item> GetItemList()
    {
        return items;
    }
    public void SetItemList(List<Item> items)
    {
        this.items = items;
    }
    public void collectItem(Item item)
    {

    }
    public void useItem(Item item)
    {

    }
}
