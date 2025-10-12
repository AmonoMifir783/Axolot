using UnityEngine;

public class ItemSystemControl : MonoBehaviour
{
    private ItemsActions itemsActions;
    private Object_Identification objectIdentification;
    public GameObject targetObject;

    void Start()
    {
        itemsActions = GetComponent<ItemsActions>();
        objectIdentification = GetComponent<Object_Identification>();
    }

    void Update()
    {
        UpdateTargetObject();

        if (Input.GetKeyDown(KeyCode.E) && targetObject != null)
        {
            Debug.Log("Подобрать: " + targetObject.name);
            if (itemsActions != null)
            {
                itemsActions.DestroyObject(targetObject);
                // После уничтожения обновляем targetObject
                UpdateTargetObject();
            }
        }
    }

    private void UpdateTargetObject()
    {
        if (objectIdentification != null)
        {
            targetObject = objectIdentification.detectedObjects[0];
        }
        else
        {
            targetObject = null;
        }
    }
}
