using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombihealing : MonoBehaviour
{
    public static bool canheal = false;
    
    private float healtimer;
    private float maxhealtimer;
    [SerializeField] private Image healimage;
    public static int healcount;

    [SerializeField] Text healcounttext;
    [SerializeField] Text healtext;

    private playershooting _playerstatus;
    // Start is called before the first frame update
    void Start()
    {
        _playerstatus = FindObjectOfType<playershooting>();
       
        if (PlayerPrefs.GetString("loadit")=="true")
        {
            healcount = _playerstatus.mystats.healcount;
        }
        else if (PlayerPrefs.GetString("loadit")=="false")
        
        {
            healcount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        healcounttext.text = "Zombies Healed  " + healcount;
        healimage.fillAmount = healtimer / 100;
        healtext.text = "Heal"+ healtimer+"%";
        if (canheal && Input.GetKey(KeyCode.H))
        {
            
            healtimer ++;
        }
        else
        {
            healtimer = 0;
            
        }

        if (healtimer>=100)
        {
            healcounter();
            canheal = false;
            Invoke("destroy",1);
            
        }
        if (healcount>=5)
        {
            
            Scenamanager.instance.win();
        }

        _playerstatus.mystats.healcount = healcount;
    }

    void healcounter()
    {
        healcount++;
        _playerstatus.mystats.healcount = healcount;
    }

    public void destroy()
    {
        Destroy(gameObject);
    }
}
