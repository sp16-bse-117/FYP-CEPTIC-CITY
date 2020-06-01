using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdperesonrot : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var roty = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up*roty*sensitivity);
    }
}
