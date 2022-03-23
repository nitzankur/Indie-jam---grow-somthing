using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnItemChanged();

    public List<Item> items = new List<Item>();

    private readonly int _space = 20;

    public OnItemChanged OnItemChangedCallback;

    public bool Add(Item i)
    {
        if (items.Count >= _space) return false;
        items.Add(i);
        OnItemChangedCallback?.Invoke();
        return true;
    }

    public void Remove(Item i)
    {
        items.Remove(i);
        OnItemChangedCallback?.Invoke();
    }

    #region Singelton

    public static Inventory UserInventory;

    private void Awake()
    {
        if (UserInventory != null) return;
        UserInventory = this;
    }

    #endregion
}