using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YildizSistemiTotalLevel1 : MonoBehaviour
{
    public GameObject Yildiz_1, Yildiz_2, Yildiz_3, Puan_Arka_Plani, Cevap1, Cevap2, Cevap3, Cevap4, Next, Play_Again, Type, Level;
    public UnityEngine.UI.Text Kullaným_sayisi, Zaman;
    int yildiz_1, yildiz_2, yildiz_3, kullanim_sayisi = 15;
    float time = 60f;
    public void puan()
    {
        kullanim_sayisi = kullanim_sayisi - 1;
        Kullaným_sayisi.text = "Remainder\n" + kullanim_sayisi;
        if (total_level1.TrueSayisi <= 15 && total_level1.TrueSayisi > 12 && total_level1.FalseSayisi < 3 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            Yildiz_2.SetActive(true);
            Yildiz_3.SetActive(true);
            Cevap1.SetActive(false);
            Cevap2.SetActive(false);
            Cevap3.SetActive(false);
            Cevap4.SetActive(false);
        }
        else if (total_level1.TrueSayisi <= 12 && total_level1.TrueSayisi > 9 && total_level1.FalseSayisi < 6 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            Yildiz_2.SetActive(true);
            Cevap1.SetActive(false);
            Cevap2.SetActive(false);
            Cevap3.SetActive(false);
            Cevap4.SetActive(false);
        }
        else if (total_level1.TrueSayisi <= 9 && total_level1.TrueSayisi >= 6 && total_level1.FalseSayisi <= 9 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Next.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Yildiz_1.SetActive(true);
            Cevap1.SetActive(false);
            Cevap2.SetActive(false);
            Cevap3.SetActive(false);
            Cevap4.SetActive(false);
        }
        else if (total_level1.TrueSayisi <= 5 && total_level1.FalseSayisi >= 10 && kullanim_sayisi == 0)
        {
            Level.SetActive(true);
            Type.SetActive(true);
            Play_Again.SetActive(true);
            Puan_Arka_Plani.SetActive(true);
            Cevap1.SetActive(false);
            Cevap2.SetActive(false);
            Cevap3.SetActive(false);
            Cevap4.SetActive(false);
        }
    }

    void Start()
    {

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
            Cevap1.SetActive(false);
            Cevap2.SetActive(false);
            Cevap3.SetActive(false);
            Cevap4.SetActive(false);
            puan();
        }
    }
}
