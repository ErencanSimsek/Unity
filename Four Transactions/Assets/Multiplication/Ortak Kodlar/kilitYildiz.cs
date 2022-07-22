using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilitYildiz : MonoBehaviour
{
    void Start()
    {
        kilitac();
        YildizGetir();
    }
    void Update()
    {

    }
    public GameObject Kilit2, Acik_Kilit2, Kilit3, Acik_Kilit3, Kilit4, Acik_Kilit4, Kilit5, Acik_Kilit5, Kilit6, Acik_Kilit6, Kilit7, Acik_Kilit7, Kilit8, Acik_Kilit8, Kilit9, Acik_Kilit9, Kilit10, Acik_Kilit10,
        _1Yildiz1, _1Yildiz2, _1Yildiz3, _2Yildiz1, _2Yildiz2, _2Yildiz3, _3Yildiz1, _3Yildiz2, _3Yildiz3, _4Yildiz1, _4Yildiz2, _4Yildiz3, _5Yildiz1, _5Yildiz2, _5Yildiz3,
        _6Yildiz1, _6Yildiz2, _6Yildiz3, _7Yildiz1, _7Yildiz2, _7Yildiz3, _8Yildiz1, _8Yildiz2, _8Yildiz3, _9Yildiz1, _9Yildiz2, _9Yildiz3, _10Yildiz1, _10Yildiz2, _10Yildiz3;
    public void kilitac()
    {
        if (Mul_level1.TrueSayisi <= 15 && Mul_level1.TrueSayisi >= 6 && Mul_level1.FalseSayisi <= 9)
        {
            Acik_Kilit2.SetActive(true);
            Kilit2.SetActive(false);
        }
        if (Mul_level2.Truesayisi <= 15 && Mul_level2.Truesayisi >= 6 && Mul_level2.Falsesayisi <= 9)
        {
            Acik_Kilit3.SetActive(true);
            Kilit3.SetActive(false);
        }
        if (Mul_level3.TrueSayisi <= 15 && Mul_level3.TrueSayisi >= 6 && Mul_level3.FalseSayisi <= 9)
        {
            Acik_Kilit4.SetActive(true);
            Kilit4.SetActive(false);
        }

        if (Mul_level4.Truesayisi <= 15 && Mul_level4.Truesayisi >= 6 && Mul_level4.Falsesayisi <= 9)
        {
            Acik_Kilit8.SetActive(true);
            Kilit8.SetActive(false);
        }
        if (Mul_level8.Truesayisi <= 15 && Mul_level8.Truesayisi >= 6 && Mul_level8.Falsesayisi <= 9)
        {
            Acik_Kilit10.SetActive(true);
            Kilit10.SetActive(false);
        }
    }
    public void YildizGetir()
    {
        if (Mul_level1.TrueSayisi <= 15 && Mul_level1.TrueSayisi > 12 && Mul_level1.FalseSayisi < 3)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
            _1Yildiz3.SetActive(true);
        }
        else if (Mul_level1.TrueSayisi <= 12 && Mul_level1.TrueSayisi > 9 && Mul_level1.FalseSayisi < 6)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
        }
        else if (Mul_level1.TrueSayisi <= 9 && Mul_level1.TrueSayisi >= 6 && Mul_level1.FalseSayisi <= 9)
        {
            _1Yildiz1.SetActive(true);
        }
        ////////////
        if (Mul_level2.Truesayisi <= 15 && Mul_level2.Truesayisi > 12 && Mul_level2.Falsesayisi < 3)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
            _2Yildiz3.SetActive(true);
        }
        else if (Mul_level2.Truesayisi <= 12 && Mul_level2.Truesayisi > 9 && Mul_level2.Falsesayisi < 6)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
        }
        else if (Mul_level2.Truesayisi <= 9 && Mul_level2.Truesayisi >= 6 && Mul_level2.Falsesayisi <= 9)
        {
            _2Yildiz1.SetActive(true);
        }

        ///////////////////
        if (Mul_level3.TrueSayisi <= 15 && Mul_level3.TrueSayisi > 12 && Mul_level3.FalseSayisi < 3)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
            _3Yildiz3.SetActive(true);
        }
        else if (Mul_level3.TrueSayisi <= 12 && Mul_level3.TrueSayisi > 9 && Mul_level3.FalseSayisi < 6)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
        }
        else if (Mul_level3.TrueSayisi <= 9 && Mul_level3.TrueSayisi >= 6 && Mul_level3.FalseSayisi <= 9)
        {
            _3Yildiz1.SetActive(true);
        }

        //////////////////////
        if (Mul_level4.Truesayisi <= 15 && Mul_level4.Truesayisi > 12 && Mul_level4.Falsesayisi < 3)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
            _4Yildiz3.SetActive(true);
        }
        else if (Mul_level4.Truesayisi <= 12 && Mul_level4.Truesayisi > 9 && Mul_level4.Falsesayisi < 6)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
        }
        else if (Mul_level4.Truesayisi <= 9 && Mul_level4.Truesayisi >= 6 && Mul_level4.Falsesayisi <= 9)
        {
            _4Yildiz1.SetActive(true);
        }

        //////////////////////
        
        if (Mul_level8.Truesayisi <= 15 && Mul_level8.Truesayisi > 12 && Mul_level8.Falsesayisi < 3)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
            _8Yildiz3.SetActive(true);
        }
        else if (Mul_level8.Truesayisi <= 12 && Mul_level8.Truesayisi > 9 && Mul_level8.Falsesayisi < 6)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
        }
        else if (Mul_level8.Truesayisi <= 9 && Mul_level8.Truesayisi >= 6 && Mul_level8.Falsesayisi <= 9)
        {
            _8Yildiz1.SetActive(true);
        }
        ////////////////////////////
        if (Mul_level10.Truesayisi <= 15 && Mul_level10.Truesayisi > 12 && Mul_level10.Falsesayisi < 3)
        {
            _10Yildiz1.SetActive(true);
            _10Yildiz2.SetActive(true);
            _10Yildiz3.SetActive(true);
        }
        else if (Mul_level10.Truesayisi <= 12 && Mul_level10.Truesayisi > 9 && Mul_level10.Falsesayisi < 6)
        {
            _10Yildiz1.SetActive(true);
            _10Yildiz2.SetActive(true);
        }
        else if (Mul_level10.Truesayisi <= 9 && Mul_level10.Truesayisi >= 6 && Mul_level10.Falsesayisi <= 9)
        {
            _10Yildiz1.SetActive(true);
        }
    }
}
