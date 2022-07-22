using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Div_Seviye : MonoBehaviour
{
    public UnityEngine.UI.Button Level1, Level2, Level3, Level4, Level5;
    public static bool level1, level2, level3, level4, level5;
    void Start()
    {
        level1 = true;
    }
    
    void Update()
    {
        if (level2 == true)
        {
            Level2.interactable = true;
        }
        if (level3 == true)
        {
            Level3.interactable = true;
        }
        if (level4 == true)
        {
            Level4.interactable = true;
        }
        if (level5 == true)
        {
            Level5.interactable = true;
        }
    }
}
