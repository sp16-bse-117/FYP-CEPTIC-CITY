using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class cameraeffects : MonoBehaviour
{
    public  static float blasttimer=15f;

    public GameObject blast;
    public GameObject door;
    public static bool canstart=false;

  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (canstart)
        {
            blasttimer -= Time.deltaTime; 
        }
        
        if (blasttimer<=0)
        {
            blast.SetActive(true);
            door.SetActive(false);

        }
    }

   
}
