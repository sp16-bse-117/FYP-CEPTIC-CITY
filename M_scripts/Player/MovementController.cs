using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float sensitivity;
    [SerializeField] private float Y_Sensitivity;

    private Vector3 velocity = Vector3.zero;
    private Vector3 upanddownrotation=Vector3.zero;
    private Vector3 rotation=Vector3.zero;
    private Vector3 yrotation=Vector3.zero;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {//movement
        float xinput = Input.GetAxis("Horizontal");
        float yinput = Input.GetAxis("Vertical");
        Vector3 xmovement = transform.right*xinput;
        Vector3 ymovement = transform.forward*yinput;
        Vector3 movement = (xmovement + ymovement).normalized * speed;
        Move(movement);
        //rotation x
        float bodyrotation = Input.GetAxis("Mouse X");
        Vector3 rotationvector=new Vector3(0,bodyrotation,0)*sensitivity;
       
        Rotaterb(rotationvector);
       

    }

    private void FixedUpdate()
    {        

        if (velocity!=Vector3.zero)
        {
            rb.MovePosition(rb.position+velocity*Time.fixedDeltaTime);
        }
        rb.MoveRotation(rb.rotation*Quaternion.Euler(rotation));
      
      
    }

    void Move(Vector3 mvelocity)
    {
        velocity = mvelocity;
    }

    void Rotaterb(Vector3 rotationvec)
    {
        rotation = rotationvec;
    }

    void RotateCamera(Vector3 camerarotatoion)
    {
        yrotation=camerarotatoion;
        
    }
}
