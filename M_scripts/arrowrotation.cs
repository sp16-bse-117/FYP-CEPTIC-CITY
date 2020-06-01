using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowrotation : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Vector3 axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }

    void rotate()
    {
        transform.Rotate(axis*speed*Time.deltaTime);
    }
}
