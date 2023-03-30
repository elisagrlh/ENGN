using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left, devices);
        Debug.Log("check1");

        foreach (var item in devices)
        {
            Debug.Log("check2");
            Debug.Log(item.name + item.characteristics);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
