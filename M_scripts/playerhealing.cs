using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealing : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Playerlife>().life += 0.1f;
            Destroy(gameObject);
        }
    }
}
