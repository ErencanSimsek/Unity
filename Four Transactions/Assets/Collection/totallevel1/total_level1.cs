using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class total_level1 : MonoBehaviour
{
    public UnityEngine.UI.Text Sayi1, Sayi2, Islem, Sonuc, Cevap1, Cevap2, Cevap3, Cevap4, True, False;
    int sayi1, sayi2, islem, sonuc, cevap1, cevap2, cevap3, cevap4, islemSonucu, islemSonucu1, islemSonucu2;
    public static int TrueSayisi = 0, FalseSayisi = 0;
    void Start()
    {
        YeniSoru();
    }
    void Update()
    {

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
                sayi1 = Random.Range(0, 21);
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
                    sayi2 = Random.Range(0, 21);
                    Sayi2.text = sayi2 + "";
                }
                break;
            case 2:
                sayi2 = Random.Range(0, 21);
                Sayi2.text = sayi2 + "";
                break;

        }
        sonuc = Random.Range(1, 2);
        switch (sonuc)
        {
            case 1:
                if (Sayi1.text == "?" || Sayi2.text == "?")
                {
                    sonuc = Random.Range(0, 41);
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
                    Cevap1.text = sayi1 + sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap1.text = sonuc - sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap1.text = sonuc - sayi1 + "";
                }
                break;
            case 2:
                cevap1 = Random.Range(0, 41);
                Cevap1.text = cevap1 + "";
                break;
        }
        cevap2 = Random.Range(1, 3);
        switch (cevap2)
        {
            case 1:
                if (Sonuc.text == "?")
                {
                    Cevap2.text = sayi1 + sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap2.text = sonuc - sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap2.text = sonuc - sayi1 + "";
                }
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(0, 41);
                    Cevap2.text = cevap2 + "";
                    if (Cevap1.text == Cevap2.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap2 = Random.Range(0, 41);
                Cevap2.text = cevap2 + "";
                while (Cevap1.text == Cevap2.text)
                {
                    cevap2 = Random.Range(0, 41);
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
                    Cevap3.text = sayi1 + sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap3.text = sonuc - sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap3.text = sonuc - sayi1 + "";
                }
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(0, 41);
                    Cevap3.text = cevap3 + "";
                    if (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                    {
                        continue;
                    }
                }
                break;
            case 2:
                cevap3 = Random.Range(0, 41);
                Cevap3.text = cevap3 + "";
                while (Cevap1.text == Cevap3.text || Cevap2.text == Cevap3.text)
                {
                    cevap3 = Random.Range(0, 41);
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
                    Cevap4.text = sayi1 + sayi2 + "";
                }
                else if (Sayi1.text == "?")
                {
                    Cevap4.text = sonuc - sayi2 + "";
                }
                else if (Sayi2.text == "?")
                {
                    Cevap4.text = sonuc - sayi1 + "";
                }
                while (Cevap4.text == Cevap1.text || Cevap4.text == Cevap2.text || Cevap4.text == Cevap3.text)
                {
                    cevap4 = Random.Range(0, 41);
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
        islemSonucu = sayi1 + sayi2;
        islemSonucu1 = sonuc - sayi1;
        islemSonucu2 = sonuc - sayi2;
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
        islemSonucu = sayi1 + sayi2;
        islemSonucu1 = sonuc - sayi1;
        islemSonucu2 = sonuc - sayi2;
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
        islemSonucu = sayi1 + sayi2;
        islemSonucu1 = sonuc - sayi1;
        islemSonucu2 = sonuc - sayi2;
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
        islemSonucu = sayi1 + sayi2;
        islemSonucu1 = sonuc - sayi1;
        islemSonucu2 = sonuc - sayi2;
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