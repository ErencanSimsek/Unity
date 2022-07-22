using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class totallevel6 : MonoBehaviour
{
    public UnityEngine.UI.Text Sayi1, Sayi2,Sayi3, Sonuc, ebk, True, False, Zaman, Kalan, Cevap1, Cevap2, Cevap3;
    int sayi1, sayi2,sayi3, sonuc;
    public static int Truesayisi = 0, Falsesayisi = 0;
    public GameObject Yildiz_1, Yildiz_2, Yildiz_3, Puan_Arka_Plani, CCevap1, CCevap2, CCevap3,Next, Play_Again, Type, Level;
    int yildiz_1, yildiz_2, yildiz_3, kullanim_sayisi = 15;
    float time = 61f;
    public void next()
    {
        SceneManager.LoadScene(1);
    }
    public void play_again()
    {
        SceneManager.LoadScene(10);
        Truesayisi = 0;
        Falsesayisi = 0;
    }
    public void seviye_7_gecis()
    {
        if (Truesayisi >= 6)
        {
            Total_Seviye.level7 = true;

        }
    }
    public void puan()
    {
        kullanim_sayisi = kullanim_sayisi - 1;
        Kalan.text = "Remainder\n" + kullanim_sayisi;
        if (Truesayisi <= 15 && Truesayisi > 12 && Falsesayisi < 3 && kullanim_sayisi == 0)
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
        }
        else if (Truesayisi <= 12 && Truesayisi > 9 && Falsesayisi < 6 && kullanim_sayisi == 0)
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
        }
        else if (Truesayisi <= 9 && Truesayisi >= 6 && Falsesayisi <= 9 && kullanim_sayisi == 0)
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
        }
        else if (Truesayisi <= 5 && Falsesayisi >= 10 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            CCevap1.SetActive(false);
            CCevap2.SetActive(false);
            CCevap3.SetActive(false);
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
            puan();
        }
    }
    void Start()
    {
        YeniSoru();
    }
    public void YeniSoru()
    {
        sayi1 = Random.Range(0, 11);
        sayi2 = Random.Range(0, 11);
        sayi3 = Random.Range(0, 11);
        sonuc = Random.Range(10, 31);
        ebk.text = "?";
        Cevap1.text = "=";
        Cevap2.text = ">";
        Cevap3.text = "<";
        Sayi1.text = sayi1 + "";
        Sayi2.text = sayi2 + "";
        Sayi3.text = sayi3 + "";
        Sonuc.text = sonuc + "";
    }
    public void esit()
    {
        if (sonuc==sayi1+sayi2+sayi3)
        {
            Truesayisi = Truesayisi + 1;
            True.text = "True\n" + Truesayisi;
        }
        else
        {
            Falsesayisi = Falsesayisi + 1;
            False.text = "False\n" + Falsesayisi;
        }
    }
    public void buyuk()
    {
        if (sonuc < sayi1 + sayi2 + sayi3)
        {
            Truesayisi = Truesayisi + 1;
            True.text = "True\n" + Truesayisi;
        }
        else
        {
            Falsesayisi = Falsesayisi + 1;
            False.text = "False\n" + Falsesayisi;
        }
    }
    public void kucuk()
    {
        if (sonuc > sayi1 + sayi2 + sayi3)
        {
            Truesayisi = Truesayisi + 1;
            True.text = "True\n" + Truesayisi;
        }
        else
        {
            Falsesayisi = Falsesayisi + 1;
            False.text = "False\n" + Falsesayisi;
        }
    }
}