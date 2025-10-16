using UnityEngine;

public class ItemSystemControl : MonoBehaviour
{
    private ItemsActions itemsActions;
    public Object_Identification objectIdentification;
    public SlotActions slotActions; // Изменено: Slot -> SlotActions
    public GameObject targetObject;
    

    void Update()
    {
        UpdateTargetObject();

        if (Input.GetKeyDown(KeyCode.E) && targetObject != null)
        {
            Debug.Log("Подобрать: " + targetObject.name);
            if (itemsActions != null)
            {
                // Передаем данные в SlotActions перед уничтожением
                
                
                //slotActions.AddItem(targetObjects);
                
                
                //TransferItemDataToSlotActions(targetObject);
                itemsActions.DestroyObject(targetObject);
                // После уничтожения обновляем targetObject
                UpdateTargetObject();
            }
        }
    }

    private void UpdateTargetObject()
    {
        if (objectIdentification != null && 
            objectIdentification.detectedObjects.Count > 0)
        {
            targetObject = objectIdentification.detectedObjects[0];
            Debug.Log(targetObject);
            
            // Передаем данные об объекте в SlotActions
            //TransferItemDataToSlotActions(targetObject);
        }
        else
        {
            targetObject = null;
            // Очищаем слот если объектов нет
            // if (slotActions != null)
            // {
            //     slotActions.ClearSlot();
            // }
        }
    }

    private void TransferItemDataToSlotActions(GameObject obj)
    {
        if (slotActions == null || obj == null) return;

        // Получаем компонент ItemInform с объекта
        ItemInform itemInfo = obj.GetComponent<ItemInform>();
        
        if (itemInfo != null)
        {
            // Передаем данные в SlotActions через метод AddItem
            slotActions.AddItem(itemInfo);
            //Debug.Log($"Данные переданы в SlotActions: {itemInfo.name}");
        }
        else
        {
            Debug.LogWarning($"На объекте {obj.name} нет компонента ItemInform");
        }
    }
}