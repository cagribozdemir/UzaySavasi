using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{
    GeriSayimSayaci geriSayimSayaci;
    float baslangicZamani;
    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();

        baslangicZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);

            baslangicZamani = Time.time;
            geriSayimSayaci.Calistir();
        }
    }
}
