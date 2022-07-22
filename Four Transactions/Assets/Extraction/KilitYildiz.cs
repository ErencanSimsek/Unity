using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilitYildiz : MonoBehaviour
{
    void Start()
    {
        kilitac();
        YildizGetir();
    }

    public GameObject Kilit2, Acik_Kilit2, Kilit3, Acik_Kilit3, Kilit4, Acik_Kilit4, Kilit5, Acik_Kilit5, Kilit6, Acik_Kilit6, Kilit7, Acik_Kilit7, Kilit8, Acik_Kilit8,
        _1Yildiz1, _1Yildiz2, _1Yildiz3, _2Yildiz1, _2Yildiz2, _2Yildiz3, _3Yildiz1, _3Yildiz2, _3Yildiz3, _4Yildiz1, _4Yildiz2, _4Yildiz3, _5Yildiz1, _5Yildiz2, _5Yildiz3,
        _6Yildiz1, _6Yildiz2, _6Yildiz3, _7Yildiz1, _7Yildiz2, _7Yildiz3, _8Yildiz1, _8Yildiz2, _8Yildiz3;
    public void kilitac()
    {
        if (level1.TrueSayisi <= 15 && level1.TrueSayisi >= 6 && level1.FalseSayisi <= 9)
        {
            Acik_Kilit2.SetActive(true);
            Kilit2.SetActive(false);
        }
        if (level2.Truesayisi <= 15 && level2.Truesayisi >= 6 && level2.Falsesayisi <= 9)
        {
            Acik_Kilit3.SetActive(true);
            Kilit3.SetActive(false);
        }
        if (level3.TrueSayisi <= 15 && level3.TrueSayisi >= 6 && level3.FalseSayisi <= 9)
        {
            Acik_Kilit4.SetActive(true);
            Kilit4.SetActive(false);
        }
        
        if (level4.Truesayisi <= 15 && level4.Truesayisi >= 6 && level4.Falsesayisi <= 9)
        {
            Acik_Kilit5.SetActive(true);
            Kilit5.SetActive(false);
        }
        
        if (level5.TrueSayisi <= 15 && level5.TrueSayisi >= 6 && level5.FalseSayisi <= 9)
        {
            Acik_Kilit6.SetActive(true);
            Kilit6.SetActive(false);
        }
        if (level6.Truesayisi <= 15 && level6.Truesayisi >= 6 && level6.Falsesayisi <= 9)
        {
            Acik_Kilit7.SetActive(true);
            Kilit7.SetActive(false);
        }
        if (level7.TrueSayisi <= 15 && level7.TrueSayisi >= 6 && level7.FalseSayisi <= 9)
        {
            Acik_Kilit8.SetActive(true);
            Kilit8.SetActive(false);
        }
    }
    public void YildizGetir()
    {
        if (level1.TrueSayisi <= 15 && level1.TrueSayisi > 12 && level1.FalseSayisi < 3)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
            _1Yildiz3.SetActive(true);
        }
        else if (level1.TrueSayisi <= 12 && level1.TrueSayisi > 9 && level1.FalseSayisi < 6)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
        }
        else if (level1.TrueSayisi <= 9 && level1.TrueSayisi >= 6 && level1.FalseSayisi <= 9)
        {
            _1Yildiz1.SetActive(true);
        }
        ////////////
        if (level2.Truesayisi <= 15 && level2.Truesayisi > 12 && level2.Falsesayisi < 3)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
            _2Yildiz3.SetActive(true);
        }
        else if (level2.Truesayisi <= 12 && level2.Truesayisi > 9 && level2.Falsesayisi < 6)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
        }
        else if (level2.Truesayisi <= 9 && level2.Truesayisi >= 6 && level2.Falsesayisi <= 9)
        {
            _2Yildiz1.SetActive(true);
        }
        
        ///////////////////
        if (level3.TrueSayisi <= 15 && level3.TrueSayisi > 12 && level3.FalseSayisi < 3)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
            _3Yildiz3.SetActive(true);
        }
        else if (level3.TrueSayisi <= 12 && level3.TrueSayisi > 9 && level3.FalseSayisi < 6)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
        }
        else if (level3.TrueSayisi <= 9 && level3.TrueSayisi >= 6 && level3.FalseSayisi <= 9)
        {
            _3Yildiz1.SetActive(true);
        }
        
        //////////////////////
        if (level4.Truesayisi <= 15 && level4.Truesayisi > 12 && level4.Falsesayisi < 3)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
            _4Yildiz3.SetActive(true);
        }
        else if (level4.Truesayisi <= 12 && level4.Truesayisi > 9 && level4.Falsesayisi < 6)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
        }
        else if (level4.Truesayisi <= 9 && level4.Truesayisi >= 6 && level4.Falsesayisi <= 9)
        {
            _4Yildiz1.SetActive(true);
        }
        
        //////////////////////
        if (level6.Truesayisi <= 15 && level6.Truesayisi > 12 && level6.Falsesayisi < 3)
        {
            _6Yildiz1.SetActive(true);
            _6Yildiz2.SetActive(true);
            _6Yildiz3.SetActive(true);
        }
        else if (level6.Truesayisi <= 12 && level6.Truesayisi > 9 && level6.Falsesayisi < 6)
        {
            _6Yildiz1.SetActive(true);
            _6Yildiz2.SetActive(true);
        }
        else if (level6.Truesayisi <= 9 && level6.Truesayisi >= 6 && level6.Falsesayisi <= 9)
        {
            _6Yildiz1.SetActive(true);
        }
        //////////////////////////
        if (level7.TrueSayisi <= 15 && level7.TrueSayisi > 12 && level7.FalseSayisi < 3)
        {
            _7Yildiz1.SetActive(true);
            _7Yildiz2.SetActive(true);
            _7Yildiz3.SetActive(true);
        }
        else if (level7.TrueSayisi <= 12 && level7.TrueSayisi > 9 && level7.FalseSayisi < 6)
        {
            _7Yildiz1.SetActive(true);
            _7Yildiz2.SetActive(true);
        }
        else if (level7.TrueSayisi <= 9 && level7.TrueSayisi >= 6 && level7.FalseSayisi <= 9)
        {
            _7Yildiz1.SetActive(true);
        }
        ///////////////////////////
        if (level8.Truesayisi <= 15 && level8.Truesayisi > 12 && level8.Falsesayisi < 3)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
            _8Yildiz3.SetActive(true);
        }
        else if (level8.Truesayisi <= 12 && level8.Truesayisi > 9 && level8.Falsesayisi < 6)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
        }
        else if (level8.Truesayisi <= 9 && level8.Truesayisi >= 6 && level8.Falsesayisi <= 9)
        {
            _8Yildiz1.SetActive(true);
        }

        ////////////////////////////
        
        if (level5.TrueSayisi <= 15 && level5.TrueSayisi > 12 && level5.FalseSayisi < 3)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
            _5Yildiz3.SetActive(true);
        }
        else if (level5.TrueSayisi <= 12 && level5.TrueSayisi > 9 && level5.FalseSayisi < 6)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
        }
        else if (level5.TrueSayisi <= 9 && level5.TrueSayisi >= 6 && level5.FalseSayisi <= 9)
        {
            _5Yildiz1.SetActive(true);
        }
    }
}
