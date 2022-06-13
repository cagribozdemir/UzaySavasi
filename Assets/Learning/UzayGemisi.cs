using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// Geminin maksimum hýz limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Uzay gemisinin rengi
    /// </summary>
    string renk;


    /// <summary>
    /// Maksimum hýz deðerini döner
    /// </summary>
    public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }

    /// <summary>
    /// Geminin rengini döner
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }

    /// <summary>
    /// Maksimum hýz ve rengi yazýn
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }

    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }

    /// <summary>
    /// Uzya gemisi hýzlandýrma süper gücü
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }

    /// <summary>
    /// Uzay gemisi yavaþlatma
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 15);
        Debug.Log(maksimumHiz);
    }
}
