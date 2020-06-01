using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammovement : MonoBehaviour
{
    [SerializeField]float sennsivity;
    private float X_rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        var rotx = Input.GetAxis("Mouse Y")*sennsivity;
        X_rotation -= rotx;
        X_rotation = Mathf.Clamp(X_rotation, -65, 85);
        transform.localRotation = Quaternion.Euler(X_rotation, 0, 0);
        if (Input.GetKey(KeyCode.Escape))
        {
                    Cursor.lockState = CursorLockMode.None;

        }
    }
}
