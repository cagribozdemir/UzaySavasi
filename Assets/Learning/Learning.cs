using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80,100));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(80, 100), "Gri");

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi1");
        }
        else if (gemi2.MaksimumHiz > gemi1.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi2");
        }
        else
        {
            Debug.Log("Berabere");
        }
        
        //int saldiranDusman = 10;
        //bool saldiriDevam = true;

        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam=false;
        //    }
        //    Debug.Log("Sald�r� alt�nday�z. D��man Say�s�: " + saldiranDusman);
        //}

        //int yokEdilenAsteroid = 30;
        //int oyuncuHp = 100;
        //if (yokEdilenAsteroid == 30 && oyuncuHp == 100)
        //{
        //    Debug.Log("M�kemmel");
        //}
        //if (yokEdilenAsteroid == 20)
        //{
        //    Debug.Log("Tebrikler Kazand�n�z!");
        //}
        //else if (yokEdilenAsteroid == 30)
        //{
        //    Debug.Log("Tebrikler Birinci Oldunuz!");
        //}
        //else
        //{
        //    Debug.Log("Maalesef Oyunu Kaybettiniz!");
        //}
        //switch (yokEdilenAsteroid)
        //{
        //    case 1:
        //        Debug.Log("G�zel ba�lang��");
        //        break;
        //    case 10:
        //        Debug.Log("Bu i�te iyisin");
        //        break ;
        //    default:
        //        Debug.Log("Maalesef Oyunu Kaybettiniz!");
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
