using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInteraction : MonoBehaviour
{
    public GameObject SpawnedObject;
    
    public void TestInteraction()
    {
        GameObject go = Instantiate(SpawnedObject, new Vector3(-2f, 2f, 0), Quaternion.identity);
        Destroy(go, 10f);
    }
}
