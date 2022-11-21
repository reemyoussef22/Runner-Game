using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundingIndicator : MonoBehaviour
{
    public bool isGrounded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}
