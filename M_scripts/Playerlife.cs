using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerlife : MonoBehaviour
{
   
    public float life;
    
    [SerializeField] private Image lifeimage;
 
    private playershooting _playerstats;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
        _playerstats = GameObject.FindObjectOfType<playershooting>();
            
            if (PlayerPrefs.GetString("loadit")=="true")      
            {
                life=_playerstats.mystats.life;
            }
            else if (PlayerPrefs.GetString("loadit")=="false")
           
            {
                life = 1;
                lifeimage.fillAmount = 1;
            }
           
         
    }

    // Update is called once per frame
    void Update()
    {
        lifeimage.fillAmount = life;
        _playerstats.mystats.life = life;
    }

    public void takedamage(float amount)
    {
       
            life -= amount;
            if (lifeimage.fillAmount <= 0)
            {
                Scenamanager.instance.gameover();
            }
        
    }
}
