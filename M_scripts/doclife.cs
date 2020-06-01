using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doclife : MonoBehaviour
{
    [SerializeField] private Image life;

    [SerializeField] private float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        takedamage();
    }

    public void takedamage()
    {
        life.fillAmount -= damage * Time.deltaTime/100;
        if (life.fillAmount<=0)
        {
            Scenamanager.instance.gameover();
        }
    }
}
