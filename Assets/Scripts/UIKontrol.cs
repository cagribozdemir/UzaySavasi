using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField] GameObject oyunAdiText;

    [SerializeField] GameObject oyunBittiText;

    [SerializeField] Text puanText;

    [SerializeField] GameObject oynaButon;

    int puan;

    // Start is called before the first frame update
    void Start()
    {
        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);
    }

    public void OyunBasladi()
    {
        puan = 0;
        oyunAdiText.gameObject.SetActive(false );
        oynaButon.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBittiText.gameObject.SetActive(false);
        PuaniGuncelle();
    }

    public void OyunBitti()
    {
        oyunBittiText.gameObject.SetActive(true);
        oynaButon.gameObject.SetActive(true);
    }

    void PuaniGuncelle()
    {
        puanText.text = "PUAN: " + puan;
    }
    
    public void AsteroidYokOldu(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case '1':
                puan += 5;
                PuaniGuncelle();
                break;
            case '2':
                puan += 10;
                PuaniGuncelle();
                break;
            case '3':
                puan += 15;
                PuaniGuncelle();
                break;
            default:
                break;
        }
    }
}
