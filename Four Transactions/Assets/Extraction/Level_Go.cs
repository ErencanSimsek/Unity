using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Go : MonoBehaviour
{
    public UnityEngine.UI.Button level_1, level_2, level_3, level_4, level_5, level_6, level_7, level_8;
    public void _level1()
    {
        SceneManager.LoadScene(16);
        if (level_1 == true)
        {
            level1.TrueSayisi = 0;
            level1.FalseSayisi = 0;
        }
    }
    public void _level2()
    {
        SceneManager.LoadScene(17);
        if(level_2 == true)
        {
            level2.Truesayisi = 0;
            level2.Falsesayisi = 0;
        }
    }
    public void _level3()
    {
        SceneManager.LoadScene(18);
        if (level_3 == true)
        {
            level3.TrueSayisi = 0;
            level3.FalseSayisi = 0;
        }
    }
    public void _level4()
    {
        SceneManager.LoadScene(19);
        if (level_4 == true)
        {
            level4.Truesayisi = 0;
            level4.Falsesayisi = 0;
        }
    }
    public void _level5()
    {
        SceneManager.LoadScene(20);
        if (level_5 == true)
        {
            level5.TrueSayisi = 0;
            level5.FalseSayisi = 0;
        }
    }
    public void _level6()
    {
        SceneManager.LoadScene(21);
        if (level_6 == true)
        {
            level6.Truesayisi = 0;
            level6.Falsesayisi = 0;
        }
    }
    public void _level7()
    {
        SceneManager.LoadScene(22);
        if (level_7 == true)
        {
            level7.TrueSayisi = 0;
            level7.FalseSayisi = 0;
        }
    }
    public void _level8()
    {
        SceneManager.LoadScene(23);
        if (level_8 == true)
        {
            level8.Truesayisi = 0;
            level8.Falsesayisi = 0;
        }
    }
   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
