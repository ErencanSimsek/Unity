using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Div_level1 : MonoBehaviour
{
    public Text Sayi1, Sayi2, Islem, Sonuc, Cevap1, Cevap2, Cevap3, Cevap4, True, False, Zaman, Kalan;
    public GameObject Yildiz_1, Yildiz_2, Yildiz_3, Puan_Arka_Plani, CCevap1, CCevap2, CCevap3, CCevap4, Next, Play_Again, Type, Level;
    int sayi1, sayi2,yer1,seviye,yer2,salla, islem, sonuc, cevap1, cevap2, cevap3, cevap4, islemSonucu, islemSonucu1, islemSonucu2,yildiz_1, yildiz_2, yildiz_3, kullanim_sayisi = 15;
    public static int TrueSayisi = 0, FalseSayisi = 0;
    float time = 66f;

    public void next()
    {
        SceneManager.LoadScene(2);
    }
    public void play_again()
    {
        SceneManager.LoadScene(30);
        TrueSayisi = 0;
        FalseSayisi = 0;
    }
    public void seviye_2_gecis()
    {
        if (TrueSayisi >= 6)
        {
            Div_Seviye.level2 = true;

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
        yer1 = Random.Range(1, 3);
        switch (yer1)
        {
            case 1:
                salla = Random.Range(1, 7);
                switch (salla)
                {
                    case 1:
                        sayi1 = 8;
                        Sayi1.text = "8";
                        break;
                    case 2:
                        sayi1 = 12;
                        Sayi1.text = "12";
                        break;
                    case 3:
                        sayi1 = 2;
                        Sayi1.text = "2";
                        break;
                    case 4:
                        sayi1 = 10;
                        Sayi1.text = "10";
                        break;
                    case 5:
                        sayi1 = 4;
                        Sayi1.text = "4";
                        break;
                    case 6:
                        sayi1 = 6;
                        Sayi1.text = "6";
                        break;
                }
                break;
            case 2:
                salla = Random.Range(1, 7);
                switch (salla)
                {
                    case 1:
                        sayi1 = 12;
                        Sayi1.text = "12";
                        break;
                    case 2:
                        sayi1 = 18;
                        Sayi1.text = "18";
                        break;
                    case 3:
                        sayi1 = 15;
                        Sayi1.text = "15";
                        break;
                    case 4:
                        sayi1 = 9;
                        Sayi1.text = "9";
                        break;
                    case 5:
                        sayi1 = 6;
                        Sayi1.text = "6";
                        break;
                    case 6:
                        sayi1 = 3;
                        Sayi1.text = "3";
                        break;
                }
                break;
        }
        yer2 = Random.Range(1, 2);
        switch (yer2)
        {
            case 1:
                if (yer1 == 1)
                {
                    sayi2 = 2;
                    Sayi2.text = "2";
                }
                else if(yer1 == 2)
                {
                    sayi2 = 3;
                    Sayi2.text = "3";
                }
                break;

        }
        sonuc = Random.Range(1, 2);
        switch (sonuc)
        {
            case 1:
                Sonuc.text = "?";
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
                Cevap1.text = sayi1 / sayi2 + "";
                break;
            case 2:
                cevap1 = Random.Range(1,7);
                Cevap1.text = cevap1 + "";
                break;
        }
        cevap2 = Random.Range(1, 3);
        switch (cevap2)
        {
            case 1:
                Cevap2.text = sayi1 / sayi2 + "";
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(1,7);
                    Cevap2.text = cevap2 + "";
                    if (Cevap1.text == Cevap2.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap2 = Random.Range(1,7);
                Cevap2.text = cevap2 + "";
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(1,7);
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
                Cevap3.text = sayi1 / sayi2 + "";
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(1,7);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap3 = Random.Range(1,7);
                Cevap3.text = cevap3 + "";
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(1,7);
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
                Cevap4.text = sayi1 / sayi2 + "";
                while (Cevap4.text == Cevap1.text || Cevap4.text == Cevap2.text || Cevap4.text == Cevap3.text)
                {
                    cevap4 = Random.Range(1,7);
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
        islemSonucu = sayi1 / sayi2;
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
    public void CevapIki()
    {
        islemSonucu = sayi1 / sayi2;
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
    public void CevapUc()
    {
        islemSonucu = sayi1 / sayi2;
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
    public void CevapDort()
    {
        islemSonucu = sayi1 / sayi2;
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
}
