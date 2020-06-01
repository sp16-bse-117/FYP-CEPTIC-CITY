using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionarrow : MonoBehaviour
{
   // [SerializeField] private Transform player;
    [SerializeField] private Transform laboritory;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(laboritory);
       
    }
}
                                    