using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieAttack : MonoBehaviour
{
    [SerializeField] private GameObject zombieattackpoint1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void attack1ON()
    {
        zombieattackpoint1.SetActive(true);
    }

    public void attack1OFF()
    {
        zombieattackpoint1.SetActive(false);
    }
}
