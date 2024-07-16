using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = 9;
        Debug.Log("Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = 8;
        Debug.Log("Exit");
    }
}
