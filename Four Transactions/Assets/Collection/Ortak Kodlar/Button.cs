using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public UnityEngine.UI.Button level_1, level_2, level_3, level_4, level_5, level_6, level_7, level_8, level_9, level_10;
    public void totalscene()
    {
        SceneManager.LoadScene("Collection");
    }
    public void dividescene()
    {
        SceneManager.LoadScene("Division");
    }
    public void impactscene()
    {
        SceneManager.LoadScene("Multiplication");
    }
    public void interestscene()
    {
        SceneManager.LoadScene("Extraction");
    }
    public void Level_1_Scene()
    {
        SceneManager.LoadScene(5);
        if (level_1 == true)
        {
            total_level1.TrueSayisi = 0;
            total_level1.FalseSayisi = 0;
        }
    }
    public void Level_2_Scene()
    {
        SceneManager.LoadScene(6);
        if (level_2 == true)
        {
            totallevel2.Truesayisi = 0;
            totallevel2.Falsesayisi = 0;
        }
    }
    public void Level_3_Scene()
    {
        SceneManager.LoadScene(7);
        if (level_3 == true)
        {
            totallevel3.TrueSayisi = 0;
            totallevel3.FalseSayisi = 0;
        }
    }
    public void Level_4_Scene()
    {
        SceneManager.LoadScene(8);
        if (level_4 == true)
        {
            totallevel4.Truesayisi = 0;
            totallevel4.Falsesayisi = 0;
        }
    }
    public void Level_5_Scene()
    {
        SceneManager.LoadScene(9);
        if (level_5 == true)
        {
            totallevel5.TrueSayisi = 0;
            totallevel5.FalseSayisi = 0;
        }
    }
    public void Level_6_Scene()
    {
        SceneManager.LoadScene(10);
        if (level_6 == true)
        {
            totallevel6.Truesayisi = 0;
            totallevel6.Falsesayisi = 0;
        }
    }
    public void Level_7_Scene()
    {
        SceneManager.LoadScene(11);
        if (level_7 == true)
        {
            totallevel7.TrueSayisi = 0;
            totallevel7.FalseSayisi = 0;
        }
    }
    public void Level_8_Scene()
    {
        SceneManager.LoadScene(12);
        if (level_8 == true)
        {
            totallevel8.Truesayisi = 0;
            totallevel8.Falsesayisi = 0;
        }
    }
    public void Level_9_Scene()
    {
        SceneManager.LoadScene(13);
        if (level_9 == true)
        {
            totallevel9.TrueSayisi = 0;
            totallevel9.FalseSayisi = 0;
        }
    }
    public void Level_10_Scene()
    {
        SceneManager.LoadScene(14);
        if (level_10 == true)
        {
            totallevel10.TrueSayisi = 0;
            totallevel10.FalseSayisi = 0;
        }
    }
}
