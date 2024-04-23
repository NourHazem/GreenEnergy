using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        light.GetComponent<ToggleOnOff>().Toggle();
    }

    private void OnEnable()
    {
        light.GetComponent<ToggleOnOff>().Toggle();
    }
}
