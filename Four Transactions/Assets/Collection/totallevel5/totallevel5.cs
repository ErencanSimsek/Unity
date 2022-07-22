using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class totallevel5 : MonoBehaviour
{
    public UnityEngine.UI.Text Sayi1, Sayi2, Sayi3, Sonuc, Cevap1, Cevap2, Cevap3, Cevap4,Cevap5,Cevap6, True, False, Zaman, Kalan;
    int sayi1, sayi2, sayi3, islem, sonuc, cevap1, cevap2, cevap3, cevap4, cevap5, cevap6, islemSonucu, islemSonucu1, islemSonucu2, islemSonucu3;
    public static int TrueSayisi = 0, FalseSayisi = 0;
    public GameObject Yildiz_1, Yildiz_2, Yildiz_3, Puan_Arka_Plani, CCevap1, CCevap2, CCevap3, CCevap4,CCevap5,CCevap6, Next, Play_Again, Type, Level;
    int yildiz_1, yildiz_2, yildiz_3, kullanim_sayisi = 15;
    float time = 66f;
    public void next()
    {
        SceneManager.LoadScene(1);
    }
    public void play_again()
    {
        SceneManager.LoadScene(9);
        TrueSayisi = 0;
        FalseSayisi = 0;
    }
    public void seviye_6_gecis()
    {
        if (TrueSayisi >= 6)
        {
            Total_Seviye.level6 = true;

        }
    }
    public void puan()
    {
        kullanim_sayisi = kullanim_sayisi - 1;
        Kalan.text = "Remainder\n" + kullanim_sayisi;
        if (TrueSayisi <= 15 && TrueSayisi > 12 && FalseSayisi < 3 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            Yildiz_2.SetActive(true);
            Yildiz_3.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
            CCevap4.SetActive(false);
            CCevap5.SetActive(false);
            CCevap6.SetActive(false);
        }
        else if (TrueSayisi <= 12 && TrueSayisi > 9 && FalseSayisi < 6 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            Yildiz_2.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
            CCevap4.SetActive(false);
            CCevap5.SetActive(false);
            CCevap6.SetActive(false);
        }
        else if (TrueSayisi <= 9 && TrueSayisi >= 6 && FalseSayisi <= 9 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
            CCevap4.SetActive(false);
            CCevap5.SetActive(false);
            CCevap6.SetActive(false);
        }
        else if (TrueSayisi <= 5 && FalseSayisi >= 10 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
            CCevap4.SetActive(false);
            CCevap5.SetActive(false);
            CCevap6.SetActive(false);
        }
    }

    
    void Update()
    {
        time = time - Time.deltaTime;
        Zaman.text = "Remaining Time\n" + (int)time;
        if (time < 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
            CCevap4.SetActive(false);
            CCevap5.SetActive(false);
            CCevap6.SetActive(false);
            puan();
        }
    }
    void Start()
    {
        YeniSoru();
    }
    
    public void YeniSoru()
    {
        sayi1 = Random.Range(1, 3);
        switch (sayi1)
        {
            case 1:
                Sayi1.text = "?";
                break;
            case 2:
                sayi1 = Random.Range(0, 11);
                Sayi1.text = sayi1 + "";
                break;
        }
        sayi2 = Random.Range(1, 3);
        switch (sayi2)
        {
            case 1:
                Sayi2.text = "?";
                if (sayi1 == 1)
                {
                    sayi2 = Random.Range(0, 11);
                    Sayi2.text = sayi2 + "";
                }
                break;
            case 2:
                sayi2 = Random.Range(0, 11);
                Sayi2.text = sayi2 + "";
                break;

        }
        sayi3 = Random.Range(1, 3);
        switch (sayi3)
        {
            case 1:
                Sayi3.text = "?";
                if (sayi1 == 1 || Sayi2.text == "?")
                {
                    sayi3 = Random.Range(0, 11);
                    Sayi3.text = sayi3 + "";
                }
                break;
            case 2:
                sayi3 = Random.Range(0, 11);
                Sayi3.text = sayi3 + "";
                break;

        }
        sonuc = Random.Range(1, 2);
        switch (sonuc)
        {
            case 1:
                if (Sayi1.text == "?" || Sayi2.text == "?" || Sayi3.text == "?")
                {
                    sonuc = Random.Range(0, 31);
                    Sonuc.text = sonuc + "";
                }
                if (Sayi1.text != "?" && Sayi2.text != "?" && Sayi3.text != "?")
                {
                    Sonuc.text = "?";
                }
                break;
        }
        CevapButton();
    }
    public void CevapButton()
    {
        cevap1 = Random.Range(1, 3);
        switch (cevap1)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap1.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap1.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap1.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap1.text = sonuc - sayi1 - sayi2 + "";
                }
                break;
            case 2:
                cevap1 = Random.Range(0, 31);
                Cevap1.text = cevap1 + "";
                break;
        }
        cevap2 = Random.Range(1, 3);
        switch (cevap2)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap2.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap2.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap2.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap2.text = sonuc - sayi1 - sayi2 + "";
                }
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(0, 31);
                    Cevap2.text = cevap2 + "";
                    if (Cevap1.text == Cevap2.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap2 = Random.Range(0, 31);
                Cevap2.text = cevap2 + "";
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(0, 31);
                    Cevap2.text = cevap2 + "";
                    if (Cevap1.text == Cevap2.text)
                    {
                        continue;
                    }
                }
                break;
        }
        cevap3 = Random.Range(1, 3);
        switch (cevap3)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap3.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap3.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap3.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap3.text = sonuc - sayi1 - sayi2 + "";
                }
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(0, 31);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap3 = Random.Range(0, 31);
                Cevap3.text = cevap3 + "";
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(0, 31);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
        }
        cevap4 = Random.Range(1, 3);
        switch (cevap4)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap4.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap4.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap4.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap4.text = sonuc - sayi1 - sayi2 + "";
                }
                while (Cevap1.text == Cevap4.text || Cevap2.text == Cevap4.text || Cevap3.text == Cevap4.text)
                {
                    cevap4 = Random.Range(0, 31);
                    Cevap4.text = cevap4 + "";
                    if (Cevap1.text == Cevap4.text || Cevap2.text == Cevap4.text || Cevap3.text == Cevap4.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap4 = Random.Range(0, 31);
                Cevap4.text = cevap4 + "";
                while (Cevap1.text == Cevap4.text || Cevap2.text == Cevap4.text || Cevap3.text == Cevap4.text)
                {
                    cevap4 = Random.Range(0, 31);
                    Cevap4.text = cevap4 + "";
                    if (Cevap1.text == Cevap4.text || Cevap2.text == Cevap4.text || Cevap3.text == Cevap4.text)
                    {
                        continue;
                    }
                }
                break;
        }
        cevap5 = Random.Range(1, 3);
        switch (cevap5)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap5.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap5.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap5.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap5.text = sonuc - sayi1 - sayi2 + "";
                }
                while (Cevap1.text == Cevap5.text || Cevap2.text == Cevap5.text || Cevap3.text == Cevap5.text || Cevap4.text==Cevap5.text)
                {
                    cevap5 = Random.Range(0, 31);
                    Cevap5.text = cevap5 + "";
                    if (Cevap1.text == Cevap5.text || Cevap2.text == Cevap5.text || Cevap3.text == Cevap5.text || Cevap4.text == Cevap5.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap5 = Random.Range(0, 31);
                Cevap5.text = cevap5 + "";
                while (Cevap1.text == Cevap5.text || Cevap2.text == Cevap5.text || Cevap3.text == Cevap5.text || Cevap4.text == Cevap5.text)
                {
                    cevap5 = Random.Range(0, 31);
                    Cevap5.text = cevap5 + "";
                    if (Cevap1.text == Cevap5.text || Cevap2.text == Cevap5.text || Cevap3.text == Cevap5.text || Cevap4.text == Cevap5.text)
                    {
                        continue;
                    }
                }
                break;
        }
        cevap6 = Random.Range(1, 2);
        switch (cevap6)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap6.text = sayi1 + sayi2 + sayi3 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap6.text = sonuc - sayi2 - sayi3 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap6.text = sonuc - sayi1 - sayi3 + "";
                }
                else if (Sayi3.text == "?")
                {
                    Cevap6.text = sonuc - sayi1 - sayi2 + "";
                }
                while (Cevap6.text == Cevap1.text || Cevap6.text == Cevap2.text || Cevap6.text == Cevap3.text || Cevap6.text==Cevap4.text || Cevap6.text==Cevap5.text)
                {
                    cevap6 = Random.Range(0, 31);
                    Cevap6.text = cevap6 + "";
                    if (Cevap6.text == Cevap1.text || Cevap6.text == Cevap2.text || Cevap6.text == Cevap3.text || Cevap6.text == Cevap4.text || Cevap6.text == Cevap5.text)
                    {
                        continue;
                    }
                }
                break;
        }
    }
    public void CevapBir()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap1.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap1.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap1.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap1.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap1.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap1.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap1.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap1.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
    public void CevapIki()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap2.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap2.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap2.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap2.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap2.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap2.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap2.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap2.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
    public void CevapUc()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap3.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap3.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap3.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap3.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap3.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap3.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap3.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap3.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
    public void CevapDort()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap4.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap4.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap4.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap4.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap4.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap4.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap4.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap4.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
    public void CevapBes()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap5.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap5.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap5.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap5.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap5.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap5.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap5.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap5.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
    public void CevapAlti()
    {
        islemSonucu = sayi1 + sayi2 + sayi3;
        islemSonucu1 = sonuc - sayi1 - sayi2;
        islemSonucu2 = sonuc - sayi2 - sayi3;
        islemSonucu3 = sonuc - sayi1 - sayi3;
        if (Sonuc.text == "?")
        {
            if (int.Parse(Cevap6.text) == islemSonucu)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap6.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi3.text == "?")
        {
            if (int.Parse(Cevap6.text) == islemSonucu1)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap6.text) != islemSonucu1)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi1.text == "?")
        {
            if (int.Parse(Cevap6.text) == islemSonucu2)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap6.text) != islemSonucu2)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
        if (Sayi2.text == "?")
        {
            if (int.Parse(Cevap6.text) == islemSonucu3)
            {
                TrueSayisi = TrueSayisi + 1;
                True.text = "True\n" + TrueSayisi;
            }
            else if (int.Parse(Cevap6.text) != islemSonucu3)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
}
