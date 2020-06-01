using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission1completion : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("doctor"))
        {
            Scenamanager.instance.win();
        }
    }
}
