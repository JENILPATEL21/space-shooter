using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooling : MonoBehaviour
{
    public static ObjPooling instance;
    List<GameObject> pooledObjects = new List<GameObject>();
    int amountToPool = 15;

    [SerializeField] private GameObject bulletprefab;

    private void Awake()
    {
        if(instance == null) { instance = this; } else if (instance != this) { Destroy(gameObject); }
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(bulletprefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    public GameObject GetPooledObj()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }
        GameObject obj = Instantiate(bulletprefab);
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj;
    }
    
}

