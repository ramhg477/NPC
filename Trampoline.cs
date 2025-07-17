using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpFactor = 1.5f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength= other.GetComponent<Jump>().jumpStrength * jumpFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength/=jumpFactor;
    }
}
