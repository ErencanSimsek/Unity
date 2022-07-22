using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Div_Go : MonoBehaviour
{
    public UnityEngine.UI.Button level1, level2, level3, level4, level5;
    public void level_1()
    {
        SceneManager.LoadScene(30);
    }
    public void level_2()
    {
        SceneManager.LoadScene(31);
    }
    public void level_3()
    {
        SceneManager.LoadScene(32);
    }
    public void level_4()
    {
        SceneManager.LoadScene(33);
    }
    public void level_5()
    {
        SceneManager.LoadScene(34);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
