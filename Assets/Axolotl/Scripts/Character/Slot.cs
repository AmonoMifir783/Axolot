using UnityEngine;

public class Slot : MonoBehaviour
{
    public ItemInform currentItem;
    public bool IsEmpty => currentItem == null;
}
