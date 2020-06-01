using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectactivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraeffects.blasttimer<=0)
        {
            Invoke("effects", 3f);
        } 
    }
    public void effects()
    {
        gameObject.GetComponent<CameraFilterPack_AAA_Blood_Hit>().enabled = true;
        gameObject.GetComponent<CameraFilterPack_Colors_HSV>().enabled = true;
    }
}
