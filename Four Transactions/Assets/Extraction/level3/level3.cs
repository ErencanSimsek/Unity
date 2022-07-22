using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
    public UnityEngine.UI.Text Sayi1, Sayi2, Sonuc, Cevap1, Cevap2, Cevap3, Cevap4, True, False, Zaman, Kalan;
    int sayi1, sayi2, sonuc, cevap1, cevap2, cevap3, cevap4, islemSonucu, islemSonucu1, islemSonucu2;
    public static int TrueSayisi = 0, FalseSayisi = 0;
    public GameObject Yildiz_1, Yildiz_2, Yildiz_3, Puan_Arka_Plani, CCevap1, CCevap2, CCevap3, CCevap4, Next, Play_Again, Type, Level;
    int yildiz_1, yildiz_2, yildiz_3, kullanim_sayisi = 15;
    float time = 61f;
    public void next()
    {
        SceneManager.LoadScene(4);
    }
    public void play_again()
    {
        SceneManager.LoadScene(18);
        TrueSayisi = 0;
        FalseSayisi = 0;
    }
    public void seviye_4_gecis()
    {
        if (TrueSayisi >= 6)
        {
            Extraction_Seviye.level4 = true;
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
                sayi1 = Random.Range(20, 26);
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
                    sayi2 = Random.Range(10, 21);
                    Sayi2.text = sayi2 + "";
                }
                break;
            case 2:
                sayi2 = Random.Range(10, 21);
                Sayi2.text = sayi2 + "";
                break;

        }
        sonuc = Random.Range(1, 2);
        switch (sonuc)
        {
            case 1:
                if (Sayi1.text == "?" || Sayi2.text == "?")
                {
                    sonuc = Random.Range(10, 21);
                    Sonuc.text = sonuc + "";
                }
                if (Sayi1.text != "?" && Sayi2.text != "?")
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
                    Cevap1.text = sayi1 - sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap1.text = sonuc + sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap1.text = sayi1 - sonuc + "";
                }
                break;
            case 2:
                cevap1 = Random.Range(10, 26);
                Cevap1.text = cevap1 + "";
                break;
        }
        cevap2 = Random.Range(1, 3);
        switch (cevap2)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap2.text = sayi1 - sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap2.text = sonuc + sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap2.text = sayi1 - sonuc + "";
                }
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(10, 26);
                    Cevap2.text = cevap2 + "";
                    if (Cevap1.text == Cevap2.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap2 = Random.Range(10, 26);
                Cevap2.text = cevap2 + "";
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(10, 26);
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
                    Cevap3.text = sayi1 - sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap3.text = sonuc + sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap3.text = sayi1 - sonuc + "";
                }
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(10, 26);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap3 = Random.Range(10, 26);
                Cevap3.text = cevap3 + "";
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(10, 26);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
        }
        cevap4 = Random.Range(1, 2);
        switch (cevap4)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap4.text = sayi1 - sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap4.text = sonuc + sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap4.text = sayi1 - sonuc + "";
                }
                while (Cevap4.text == Cevap1.text || Cevap4.text == Cevap2.text || Cevap4.text == Cevap3.text)
                {
                    cevap4 = Random.Range(10, 26);
                    Cevap4.text = cevap4 + "";
                    if (Cevap4.text == Cevap1.text || Cevap4.text == Cevap2.text || Cevap4.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
        }
    }
    public void CevapBir()
    {
        islemSonucu = sayi1 - sayi2;
        islemSonucu1 = sayi1 - sonuc;
        islemSonucu2 = sonuc + sayi2;
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
        if (Sayi2.text == "?")
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
    }
    public void CevapIki()
    {
        islemSonucu = sayi1 - sayi2;
        islemSonucu1 = sayi1 - sonuc;
        islemSonucu2 = sonuc + sayi2;
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
        if (Sayi2.text == "?")
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
    }
    public void CevapUc()
    {
        islemSonucu = sayi1 - sayi2;
        islemSonucu1 = sayi1 - sonuc;
        islemSonucu2 = sonuc + sayi2;
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
        if (Sayi2.text == "?")
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
    }
    public void CevapDort()
    {
        islemSonucu = sayi1 - sayi2;
        islemSonucu1 = sayi1 - sonuc;
        islemSonucu2 = sonuc + sayi2;
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
        if (Sayi2.text == "?")
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
            else if (int.Parse(Cevap4.text) != islemSonucu)
            {
                FalseSayisi = FalseSayisi + 1;
                False.text = "False\n" + FalseSayisi;
            }
        }
    }
}
