using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_Manger : MonoBehaviour
{
    public GameObject pause_bts;
    public GameObject Main_Menu;
    public GameObject Shop_Menu_bts;    
    public GameObject Map_Menu_bts;    
    public GameObject Settings_Menu_bts;
    public GameObject Menu_bts;
    public GameObject game_point_Menu_bts;
    public GameObject watch_ads_Menu_bts;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pause()
    {
        pause_bts.SetActive(false);
        Menu_bts.SetActive(false);
        Main_Menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void resume()
    {
        Menu_bts.SetActive(false);
        Main_Menu.SetActive(false);
        pause_bts.SetActive(true);
        Time.timeScale = 1;
    }
    public void restart_0_Scene_Load()
    {
        Menu_bts.SetActive(false);
        Main_Menu.SetActive(false);
        pause_bts.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(true);
    }
    public void Shop()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(false);
        Shop_Menu_bts.SetActive(true);
    }
    public void Map()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(false);
        Map_Menu_bts.SetActive(true);
    }
    public void game_point()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(false);
        game_point_Menu_bts.SetActive(true);
    }
    public void Settings()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(false);
        watch_ads_Menu_bts.SetActive(true);
    }
    public void watch_ads()
    {
        pause_bts.SetActive(false);
        Main_Menu.SetActive(false);
        Menu_bts.SetActive(false);
        Map_Menu_bts.SetActive(true);
    }
}