using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsTracker : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject UIElement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var go in objects)
        {
            if (!go.activeSelf)
            {
                return;
            }
        }
        // Do stuff
        UIElement.SetActive(true);
    }
}
