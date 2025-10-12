using UnityEngine;
using UnityEngine.UI;

public class SlotActions : MonoBehaviour
{
    public Slot slot;
    
    public void AddItem(ItemInform item)
    {
        if (item == null)
        {    
            slot.currentItem = item;    
        }
        
        Debug.Log($"Item {item.tag} added to slot");
    }
    
    // public void ClearSlot()
    // {
    //     if (slot.currentItem != null)
    //     {
    //         Debug.Log($"Item {slot.currentItem.tag} removed from slot");
    //         slot.currentItem = null;
    //     }
    // }
}
