using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seviye_2_Gecis : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void seviye2_gecis()
    {
        if (total_level1.TrueSayisi >= 6)
        {
            Total_Seviye.level2 = true;
        }
    }
    public void next()
    {
        SceneManager.LoadScene(1);
    }
    public void play_again()
    {
        SceneManager.LoadScene(5);
        total_level1.TrueSayisi = 0;
        total_level1.FalseSayisi = 0;
    }
}
