using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAway : MonoBehaviour
{
    public float forceApplied = 50;

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision");
        if (col.gameObject.name == "Coin Body")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
        }
    }

    }
