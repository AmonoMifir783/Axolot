using UnityEngine;
using UnityEngine.UI;

public class SlotActions : MonoBehaviour
{
    public Slot slot;
    
    public void AddItem(ItemInform item)
    {
        if (item != null) // Исправлено: было if (item == null)
        {    
            slot.currentItem = item;    
            Debug.Log($"Item {item.tag} added to slot");
        }
        else
        {
            Debug.LogWarning("Попытка добавить null item в слот");
        }
    }
    
    // public void ClearSlot()
    // {
    //     if (slot.currentItem != null)
    //     {
    //         Debug.Log($"Item {slot.currentItem.tag} removed from slot");
    //         slot.currentItem = null;
    //     }
    // }

    // Дополнительный метод для получения текущего предмета
    public ItemInform GetCurrentItem()
    {
        return slot.currentItem;
    }

    // Дополнительный метод для проверки пустоты
    public bool IsSlotEmpty()
    {
        return slot == null || slot.IsEmpty;
    }
}