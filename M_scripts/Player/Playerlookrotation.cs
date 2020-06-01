using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playerlookrotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float sensitivity;
    // [SerializeField] private float verticalVelocity;
    public Joystick rotationjoystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float rotx=rotationjoystick.Vertical*sensitivity*Time.deltaTime;
      rotx = Mathf.Clamp(rotx, -60f, 60f);
       // Mathf.Clamp(transform.rotation.y, -60, 60);
       
       
       
      
       
       
        transform.localRotation *=Quaternion.Euler(-rotx,0,0);

        //         transform.eulerAngles.y = Mathf.Clamp(transform.eulerAngles.y, -90, 90);

    }

  
}
