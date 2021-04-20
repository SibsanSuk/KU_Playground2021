using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTriggerController : MonoBehaviour
{
    public GateController gate;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        gate.gateOpen = !gate.gateOpen;
    }
}
