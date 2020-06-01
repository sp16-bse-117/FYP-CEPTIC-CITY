using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float verticalVelocity;
    [SerializeField] private float sensitivity;
    [SerializeField] private float jumpspeed;
    public Joystick movementjoystick;
    public Joystick rotationjoystick;
    private CharacterController chcon;
    // [SerializeField] private float verticalVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        chcon = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {Vector3 movedir=new Vector3(movementjoystick.Horizontal*speed,verticalVelocity,movementjoystick.Vertical*speed);
        
        float roty=rotationjoystick.Horizontal*sensitivity*Time.deltaTime;
       //Input.GetTouch(0);
       
        // Mathf.Clamp(transform.rotation.y, -60, 60);
        transform.Rotate(0,roty*sensitivity*Time.deltaTime,0);
        movedir = transform.TransformDirection(movedir);
        chcon.Move(movedir * Time.deltaTime);
        gravity();
       
        // print(transform.rotation);
    }
    public void gravity()
    {
        if (!chcon.isGrounded)
        {
            verticalVelocity = Physics.gravity.y *2* Time.deltaTime;
        }
    }

    public void jump()
    {
        if (chcon.isGrounded)
        {
            verticalVelocity = jumpspeed*Time.deltaTime;
        }
    }
}
