using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField] GameObject uzayGemisiPrefab;

    GameObject uzayGemisi;

    [SerializeField] List<GameObject> asteroidPrefabs = new List<GameObject>();

    List<GameObject> asteroidList = new List<GameObject>();

    [SerializeField] int zorluk = 1;

    [SerializeField] int carpan = 5;

    UIKontrol uikontrol;
    // Start is called before the first frame update
    void Start()
    {
        uikontrol = GetComponent<UIKontrol>();
    }

    public void OyunuBaslat()
    {
        uikontrol.OyunBasladi();
        uzayGemisi = Instantiate(uzayGemisiPrefab);
        uzayGemisi.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f);
        AsteroidUret(5);
    }
    
    void AsteroidUret(int adet)
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(EkranHesaplayicisi.Sol, EkranHesaplayicisi.Sag);
            position.y = EkranHesaplayicisi.Ust - 1;

            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, 3)], position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }
    }

    public void AsteroidYokOldu(GameObject asteroid)
    {
        uikontrol.AsteroidYokOldu(asteroid);
        asteroidList.Remove(asteroid);
        if (asteroidList.Count <= zorluk)
        {
            zorluk++;
            AsteroidUret(zorluk * carpan);
        }
    }

    public void OyunuBitir()
    {
        foreach (GameObject asteroid in asteroidList)
        {
            asteroid.GetComponent<Asteroid>().AsteroidYokEt();
        }
        asteroidList.Clear();
        zorluk = 1;
        uikontrol.OyunBitti();
    }
}
