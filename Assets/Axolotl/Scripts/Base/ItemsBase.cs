using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ItemsBase", menuName = "Scriptable Objects/ItemsBase")]
public class ItemsBase : ScriptableObject
{
    public List<ItemInform> Items = new List<ItemInform>();
}

[Serializable]
public class ItemInform
{
    public ItemTag tag;
    public GameObject prefab;
}

public enum ItemTag
{
    Seed,
    Karall,
    Algae
}
