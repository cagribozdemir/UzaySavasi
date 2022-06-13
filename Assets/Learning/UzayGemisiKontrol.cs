using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{
    const float hareketGucu = 5;

    bool topluyor=false;
    GameObject hedef;

    Rigidbody2D myRigidbody2D;

    Toplayici toplayici;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplayici>();
    }

    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTopla();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef);
            myRigidbody2D.velocity = Vector2.zero;
            GitVeTopla();
        }
    }

    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz;
        if (hedef !=null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            myRigidbody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");

        //if (yatayInput !=0)
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime; 
        //}
        //if (dikeyInput !=0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}

        //transform.position= position;
    }
}
