using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenumanager : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    // Start is called before the first frame update
    void Start()
    {
        panels[0].SetActive(true);//main
        panels[1].SetActive(false);//mission panel
        
    }

    // Update is called once per frame
    public void missions()
    {
        panels[0].SetActive(false);//main
        panels[1].SetActive(true);//mission panel
    }

    public void exit()

    {
        Application.Quit();
    }

    public void mission1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void mission2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void mission3()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void back()
    {
        panels[0].SetActive(true);//main
        panels[1].SetActive(false);//mission panel
    }

    public void musicon()
    {
       PlayerPrefs.SetInt("music",1); 
    }
    public void musicoff()
    {
        PlayerPrefs.SetInt("music",0);     

    }
}
