using System.Collections;
using System.Collections.Generic;
using System.Net.ServerSentEvents;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<SseItem>();
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
        item.Add(item);
    }
    public void useItem(Item item)
    {
        if (items.Contains(item))
        {
            item.Use(GetComponent<Player>());
            items.Remove(item);
        }
    }
}
