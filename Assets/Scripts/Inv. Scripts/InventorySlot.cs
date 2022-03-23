using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    private Item _item;

    public void AddItem(Item i)
    {
        _item = i;
        icon.sprite = i.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        _item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}