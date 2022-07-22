using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Go_ : MonoBehaviour
{
    public UnityEngine.UI.Button level_1, level_2, level_3, level_4, level_5, level_6, level_7, level_8, level_9, level_10;
    public void level1()
    {
        SceneManager.LoadScene(24);
        if (level_1)
        {
            Mul_level1.TrueSayisi = 0;
            Mul_level1.FalseSayisi = 0;
        }
    }
    public void level2()
    {
        SceneManager.LoadScene(25);
        if (level_2)
        {
            Mul_level2.Truesayisi = 0;
            Mul_level2.Falsesayisi = 0;
        }
    }
    public void level3()
    {
        SceneManager.LoadScene(26);
        if (level_3)
        {
            Mul_level3.TrueSayisi = 0;
            Mul_level3.FalseSayisi = 0;
        }
    }
    public void level4()
    {
        SceneManager.LoadScene(27);
        if (level_4)
        {
            Mul_level4.Truesayisi = 0;
            Mul_level4.Falsesayisi = 0;
        }
    }
    public void level8()
    {
        SceneManager.LoadScene(28);
        if (level_8)
        {
            Mul_level8.Truesayisi = 0;
            Mul_level8.Falsesayisi = 0;
        }
    }
    public void level10()
    {
        SceneManager.LoadScene(29);
        if (level_10)
        {
            Mul_level10.Truesayisi = 0;
            Mul_level10.Falsesayisi = 0;
        }
    }
}
