using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Div_Kilit_Yildiz : MonoBehaviour
{

    void Start()
    {
        kilitac();
        YildizGetir();
    }

    public GameObject Kilit2, Acik_Kilit2, Kilit3, Acik_Kilit3, Kilit4, Acik_Kilit4, Kilit5, Acik_Kilit5,
        _1Yildiz1, _1Yildiz2, _1Yildiz3, _2Yildiz1, _2Yildiz2, _2Yildiz3, _3Yildiz1, _3Yildiz2, _3Yildiz3, _4Yildiz1, _4Yildiz2, _4Yildiz3, _5Yildiz1, _5Yildiz2, _5Yildiz3;
    public void kilitac()
    {
        if (Div_level1.TrueSayisi <= 15 && Div_level1.TrueSayisi >= 6 && Div_level1.FalseSayisi <= 9)
        {
            Acik_Kilit2.SetActive(true);
            Kilit2.SetActive(false);
        }
        if (Div_level2.TrueSayisi <= 15 && Div_level2.TrueSayisi >= 6 && Div_level2.FalseSayisi <= 9)
        {
            Acik_Kilit3.SetActive(true);
            Kilit3.SetActive(false);
        }
        if (Div_level3.TrueSayisi <= 15 && Div_level3.TrueSayisi >= 6 && Div_level3.FalseSayisi <= 9)
        {
            Acik_Kilit4.SetActive(true);
            Kilit4.SetActive(false);
        }

        if (Div_level4.TrueSayisi <= 15 && Div_level4.TrueSayisi >= 6 && Div_level4.FalseSayisi <= 9)
        {
            Acik_Kilit5.SetActive(true);
            Kilit5.SetActive(false);
        }
    }
    public void YildizGetir()
    {
        if (Div_level1.TrueSayisi <= 15 && Div_level1.TrueSayisi > 12 && Div_level1.FalseSayisi < 3)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
            _1Yildiz3.SetActive(true);
        }
        else if (Div_level1.TrueSayisi <= 12 && Div_level1.TrueSayisi > 9 && Div_level1.FalseSayisi < 6)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
        }
        else if (Div_level1.TrueSayisi <= 9 && Div_level1.TrueSayisi >= 6 && Div_level1.FalseSayisi <= 9)
        {
            _1Yildiz1.SetActive(true);
        }
        ////////////
        if (Div_level2.TrueSayisi <= 15 && Div_level2.TrueSayisi > 12 && Div_level2.FalseSayisi < 3)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
            _2Yildiz3.SetActive(true);
        }
        else if (Div_level2.TrueSayisi <= 12 && Div_level2.TrueSayisi > 9 && Div_level2.FalseSayisi < 6)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
        }
        else if (Div_level2.TrueSayisi <= 9 && Div_level2.TrueSayisi >= 6 && Div_level2.FalseSayisi <= 9)
        {
            _2Yildiz1.SetActive(true);
        }

        ///////////////////
        if (Div_level3.TrueSayisi <= 15 && Div_level3.TrueSayisi > 12 && Div_level3.FalseSayisi < 3)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
            _3Yildiz3.SetActive(true);
        }
        else if (Div_level3.TrueSayisi <= 12 && Div_level3.TrueSayisi > 9 && Div_level3.FalseSayisi < 6)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
        }
        else if (Div_level3.TrueSayisi <= 9 && Div_level3.TrueSayisi >= 6 && Div_level3.FalseSayisi <= 9)
        {
            _3Yildiz1.SetActive(true);
        }

        //////////////////////
        if (Div_level4.TrueSayisi <= 15 && Div_level4.TrueSayisi > 12 && Div_level4.FalseSayisi < 3)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
            _4Yildiz3.SetActive(true);
        }
        else if (Div_level4.TrueSayisi <= 12 && Div_level4.TrueSayisi > 9 && Div_level4.FalseSayisi < 6)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
        }
        else if (Div_level4.TrueSayisi <= 9 && Div_level4.TrueSayisi >= 6 && Div_level4.FalseSayisi <= 9)
        {
            _4Yildiz1.SetActive(true);
        }

        //////////////////////

        if (Div_level5.TrueSayisi <= 15 && Div_level5.TrueSayisi > 12 && Div_level5.FalseSayisi < 3)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
            _5Yildiz3.SetActive(true);
        }
        else if (Div_level5.TrueSayisi <= 12 && Div_level5.TrueSayisi > 9 && Div_level5.FalseSayisi < 6)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
        }
        else if (Div_level5.TrueSayisi <= 9 && Div_level5.TrueSayisi >= 6 && Div_level5.FalseSayisi <= 9)
        {
            _5Yildiz1.SetActive(true);
        }
    }
}
