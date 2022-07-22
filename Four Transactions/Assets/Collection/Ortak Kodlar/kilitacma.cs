using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilitacma : MonoBehaviour
{
    public GameObject acik_kilit10, kilitli10, acik_kilit9, kilitli9, acik_kilit2, kilitli2, acik_kilit3, kilitli3, acik_kilit4, kilitli4, acik_kilit5, kilitli5, acik_kilit6, kilitli6, acik_kilit7, kilitli7, acik_kilit8, kilitli8,
        _10Yildiz1, _10Yildiz2, _10Yildiz3, _9Yildiz1, _9Yildiz2, _9Yildiz3, _1Yildiz1, _1Yildiz2, _1Yildiz3, _2Yildiz1, _2Yildiz2, _2Yildiz3, _3Yildiz1, _3Yildiz2, _3Yildiz3, _4Yildiz1, _4Yildiz2, _4Yildiz3, _5Yildiz1, _5Yildiz2, _5Yildiz3, _6Yildiz1, _6Yildiz2, _6Yildiz3, _7Yildiz1, _7Yildiz2, _7Yildiz3, _8Yildiz1, _8Yildiz2, _8Yildiz3;


    public void kilitac()
    {
        if(total_level1.TrueSayisi <= 15 && total_level1.TrueSayisi >= 6 && total_level1.FalseSayisi <= 9)
        {
            acik_kilit2.SetActive(true);
            kilitli2.SetActive(false);
        }
        if (totallevel2.Truesayisi <= 15 && totallevel2.Truesayisi >= 6 && totallevel2.Falsesayisi <= 9 )
        {
            acik_kilit3.SetActive(true);
            kilitli3.SetActive(false);
        }
        if (totallevel3.TrueSayisi <= 15 && totallevel3.TrueSayisi >= 6 && totallevel3.FalseSayisi <= 9 )
        {
            acik_kilit4.SetActive(true);
            kilitli4.SetActive(false);
        }
        if (totallevel4.Truesayisi <= 15 && totallevel4.Truesayisi >= 6 && totallevel4.Falsesayisi <= 9)
        {
            acik_kilit5.SetActive(true);
            kilitli5.SetActive(false);
        }
        if (totallevel5.TrueSayisi <= 15 && totallevel5.TrueSayisi >= 6 && totallevel5.FalseSayisi <= 9)
        {
            acik_kilit6.SetActive(true);
            kilitli6.SetActive(false);
        }
        if (totallevel6.Truesayisi <= 15 && totallevel6.Truesayisi >= 6 && totallevel6.Falsesayisi <= 9)
        {
            acik_kilit7.SetActive(true);
            kilitli7.SetActive(false);
        }
        if (totallevel7.TrueSayisi <= 15 && totallevel7.TrueSayisi >= 6 && totallevel7.FalseSayisi <= 9)
        {
            acik_kilit8.SetActive(true);
            kilitli8.SetActive(false);
        }
        if (totallevel8.Truesayisi <= 15 && totallevel8.Truesayisi >= 6 && totallevel8.Falsesayisi <= 9)
        {
            acik_kilit9.SetActive(true);
            kilitli9.SetActive(false);
        }
        if (totallevel9.TrueSayisi <= 15 && totallevel9.TrueSayisi >= 6 && totallevel9.FalseSayisi <= 9)
        {
            acik_kilit10.SetActive(true);
            kilitli10.SetActive(false);
        }
    }
    public void yildiz()
    {
        if (total_level1.TrueSayisi <= 15 && total_level1.TrueSayisi > 12 && total_level1.FalseSayisi < 3)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
            _1Yildiz3.SetActive(true);
        }
        else if (total_level1.TrueSayisi <= 12 && total_level1.TrueSayisi > 9 && total_level1.FalseSayisi < 6)
        {
            _1Yildiz1.SetActive(true);
            _1Yildiz2.SetActive(true);
        }
        else if (total_level1.TrueSayisi <= 9 && total_level1.TrueSayisi >= 6 && total_level1.FalseSayisi <= 9)
        {
            _1Yildiz1.SetActive(true);
        }
        if (totallevel2.Truesayisi <= 15 && totallevel2.Truesayisi > 12 && totallevel2.Falsesayisi < 3)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
            _2Yildiz3.SetActive(true);
        }
        else if (totallevel2.Truesayisi <= 12 && totallevel2.Truesayisi > 9 && totallevel2.Falsesayisi < 6)
        {
            _2Yildiz1.SetActive(true);
            _2Yildiz2.SetActive(true);
        }
        else if (totallevel2.Truesayisi <= 9 && totallevel2.Truesayisi >= 6 && totallevel2.Falsesayisi <= 9)
        {
            _2Yildiz1.SetActive(true);
        }
        if (totallevel3.TrueSayisi <= 15 && totallevel3.TrueSayisi > 12 && totallevel3.FalseSayisi < 3)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
            _3Yildiz3.SetActive(true);
        }
        else if (totallevel3.TrueSayisi <= 12 && totallevel3.TrueSayisi > 9 && totallevel3.FalseSayisi < 6)
        {
            _3Yildiz1.SetActive(true);
            _3Yildiz2.SetActive(true);
        }
        else if (totallevel3.TrueSayisi <= 9 && totallevel3.TrueSayisi >= 6 && totallevel3.FalseSayisi <= 9)
        {
            _3Yildiz1.SetActive(true);
        }
        if (totallevel4.Truesayisi <= 15 && totallevel4.Truesayisi > 12 && totallevel4.Falsesayisi < 3)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
            _4Yildiz3.SetActive(true);
        }
        else if (totallevel4.Truesayisi <= 12 && totallevel4.Truesayisi > 9 && totallevel4.Falsesayisi < 6)
        {
            _4Yildiz1.SetActive(true);
            _4Yildiz2.SetActive(true);
        }
        else if (totallevel4.Truesayisi <= 9 && totallevel4.Truesayisi >= 6 && totallevel4.Falsesayisi <= 9)
        {
            _4Yildiz1.SetActive(true);
        }
        if (totallevel5.TrueSayisi <= 15 && totallevel5.TrueSayisi > 12 && totallevel5.FalseSayisi < 3)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
            _5Yildiz3.SetActive(true);
        }
        else if (totallevel5.TrueSayisi <= 12 && totallevel5.TrueSayisi > 9 && totallevel5.FalseSayisi < 6)
        {
            _5Yildiz1.SetActive(true);
            _5Yildiz2.SetActive(true);
        }
        else if (totallevel5.TrueSayisi <= 9 && totallevel5.TrueSayisi >= 6 && totallevel5.FalseSayisi <= 9)
        {
            _5Yildiz1.SetActive(true);
        }
        if (totallevel6.Truesayisi <= 15 && totallevel6.Truesayisi > 12 && totallevel6.Falsesayisi <3)
        {
            _6Yildiz1.SetActive(true);
            _6Yildiz2.SetActive(true);
            _6Yildiz3.SetActive(true);
        }
        else if (totallevel6.Truesayisi <= 12 && totallevel6.Truesayisi > 9 && totallevel6.Falsesayisi < 6)
        {
            _6Yildiz1.SetActive(true);
            _6Yildiz2.SetActive(true);
        }
        else if (totallevel6.Truesayisi <= 9 && totallevel6.Truesayisi >= 6 && totallevel6.Falsesayisi <= 9)
        {
            _6Yildiz1.SetActive(true);
        }
        if (totallevel7.TrueSayisi <= 15 && totallevel7.TrueSayisi > 12 && totallevel7.FalseSayisi<3)
        {
            _7Yildiz1.SetActive(true);
            _7Yildiz2.SetActive(true);
            _7Yildiz3.SetActive(true);
        }
        else if (totallevel7.TrueSayisi <= 12 && totallevel7.TrueSayisi > 9 && totallevel7.FalseSayisi < 6)
        {
            _7Yildiz1.SetActive(true);
            _7Yildiz2.SetActive(true);
        }
        else if (totallevel7.TrueSayisi <= 9 && totallevel7.TrueSayisi >= 6 && totallevel7.FalseSayisi <= 9)
        {
            _7Yildiz1.SetActive(true);
        }
        if (totallevel8.Truesayisi <= 15 && totallevel8.Truesayisi > 12 && totallevel8.Falsesayisi<3)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
            _8Yildiz3.SetActive(true);
        }
        else if (totallevel8.Truesayisi <= 12 && totallevel8.Truesayisi > 9 && totallevel8.Falsesayisi < 6)
        {
            _8Yildiz1.SetActive(true);
            _8Yildiz2.SetActive(true);
        }
        else if (totallevel8.Truesayisi <= 9 && totallevel8.Truesayisi >= 6 && totallevel8.Falsesayisi <= 9)
        {
            _8Yildiz1.SetActive(true);
        }
        if (totallevel9.TrueSayisi <= 15 && totallevel9.TrueSayisi > 12 && totallevel9.FalseSayisi < 3)
        {
            _9Yildiz1.SetActive(true);
            _9Yildiz2.SetActive(true);
            _9Yildiz3.SetActive(true);
        }
        else if (totallevel9.TrueSayisi <= 12 && totallevel9.TrueSayisi > 9 && totallevel9.FalseSayisi < 6)
        {
            _9Yildiz1.SetActive(true);
            _9Yildiz2.SetActive(true);
        }
        else if (totallevel9.TrueSayisi <= 9 && totallevel9.TrueSayisi >= 6 && totallevel9.FalseSayisi <= 9)
        {
            _9Yildiz1.SetActive(true);
        }
        if (totallevel10.TrueSayisi <= 15 && totallevel10.TrueSayisi > 12 && totallevel10.FalseSayisi < 3)
        {
            _10Yildiz1.SetActive(true);
            _10Yildiz2.SetActive(true);
            _10Yildiz3.SetActive(true);
        }
        else if (totallevel10.TrueSayisi <= 12 && totallevel10.TrueSayisi > 9 && totallevel10.FalseSayisi < 6)
        {
            _10Yildiz1.SetActive(true);
            _10Yildiz2.SetActive(true);
        }
        else if (totallevel10.TrueSayisi <= 9 && totallevel10.TrueSayisi >= 6 && totallevel10.FalseSayisi <= 9)
        {
            _10Yildiz1.SetActive(true);
        }
    }
    void Start()
    {
        kilitac();
        yildiz();
    }

    void Update()
    {
        
    }
}
