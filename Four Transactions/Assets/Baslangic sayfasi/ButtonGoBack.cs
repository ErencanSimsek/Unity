using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGoBack : MonoBehaviour
{
    public UnityEngine.UI.Button Go_back;
    public void goback()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
