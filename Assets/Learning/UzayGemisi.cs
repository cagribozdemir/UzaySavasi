using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// Geminin maksimum h�z limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Uzay gemisinin rengi
    /// </summary>
    string renk;


    /// <summary>
    /// Maksimum h�z de�erini d�ner
    /// </summary>
    public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }

    /// <summary>
    /// Geminin rengini d�ner
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }

    /// <summary>
    /// Maksimum h�z ve rengi yaz�n
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
    /// Uzya gemisi h�zland�rma s�per g�c�
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }

    /// <summary>
    /// Uzay gemisi yava�latma
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 15);
        Debug.Log(maksimumHiz);
    }
}
