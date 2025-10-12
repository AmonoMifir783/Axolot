using UnityEngine;
using System.Collections.Generic;

public class Object_Identification : MonoBehaviour
{
    public List<GameObject> detectedObjects = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (IsValidObject(other.gameObject))
        {
            AddObject(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsValidObject(other.gameObject))
        {
            RemoveObject(other.gameObject);
        }
    }

    private void AddObject(GameObject obj)
    {
        if (!detectedObjects.Contains(obj))
        {
            detectedObjects.Add(obj);
        }
    }

    private void RemoveObject(GameObject obj)
    {
        if (detectedObjects.Contains(obj))
        {
            detectedObjects.Remove(obj);
        }
    }

    private bool IsValidObject(GameObject obj)
    {
        return obj.tag != "Player" && obj.tag != "Ground";
    }


    // Метод для получения текущего списка объектов
    public List<GameObject> GetDetectedObjects()
    {
        return new List<GameObject>(detectedObjects);
    }

    // Метод для проверки наличия объекта по тегу
    public bool HasObjectWithTag(string tag)
    {
        return detectedObjects.Exists(obj => obj.tag == tag);
    }

    // Метод для получения объектов по тегу
    public List<GameObject> GetObjectsWithTag(string tag)
    {
        return detectedObjects.FindAll(obj => obj.tag == tag);
    }
}
