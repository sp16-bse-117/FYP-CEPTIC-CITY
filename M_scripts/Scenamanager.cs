using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenamanager : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    // Start is called before the first frame update
    public static Scenamanager instance;
    void Start()
    {
        instance = GetComponent<Scenamanager>();
        panels[0].SetActive(false);//gameplay
        panels[1].SetActive(false);//pause
        panels[2].SetActive(false);//gameover
        panels[3].SetActive(false);//win
        panels[4].SetActive(true);//levelinfo
        Time.timeScale = 1;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        Time.timeScale = 1;
        cameraeffects.canstart = true;
        panels[0].SetActive(true);//gameplay
        panels[1].SetActive(false);//pause
        panels[2].SetActive(false);//gameover
        panels[3].SetActive(false);//win
        panels[4].SetActive(false);//levelinfo
    }

    public void pause()
    {
        Time.timeScale = 0;
        panels[0].SetActive(false);//gameplay
        panels[1].SetActive(true);//pause
        panels[2].SetActive(false);//gameover
        panels[3].SetActive(false);//win
        panels[4].SetActive(false);//levelinfo
    }
    public void gameover()
    {
        Time.timeScale = 0;
        panels[0].SetActive(false);//gameplay
        panels[1].SetActive(false);//pause
        panels[2].SetActive(true);//gameover
        panels[3].SetActive(false);//win
        panels[4].SetActive(false);//levelinfo
    }
    public void resume()
    {
        Time.timeScale = 1;
        panels[0].SetActive(true);//gameplay
        panels[1].SetActive(false);//pause
        panels[2].SetActive(false);//gameover
        panels[3].SetActive(false);//win
        panels[4].SetActive(false);//levelinfo
    }

    public void exit()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void restart()
    {
        int scennenumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(scennenumber);
    }

    public void win()
    {
        Time.timeScale = 0;
        panels[0].SetActive(false);//gameplay
        panels[1].SetActive(false);//pause
        panels[2].SetActive(false);//gameover
        panels[3].SetActive(true);//win
        panels[4].SetActive(false);//levelinfo
    }
    
}
