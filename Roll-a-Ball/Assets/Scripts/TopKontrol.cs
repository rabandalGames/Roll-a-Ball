using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    //1.bölüm Topun Hareket Etmesi
    public Rigidbody rb; //Rigidbody sýnýfýndan bir deðiþken oluþturuyoruz. Adý : rb
    public int hiz; //topun hareket etmesi için public (unity'de görünen) deðiþken yaratýyoruz.
    //1.bölüm bitiþ Topun Hareket Etmesi

    //5.bölüm puanlama 
    public int puan; 
    public int kupSayisi;

    public Text puanText;
    public Text oyunBittiText;
    //5.bölüm puanlama

    void Start()
    {
        //1.bölüm Topun Hareket Etmesi
        rb = GetComponent<Rigidbody>();
        //1.bölüm Topun Hareket Etmesi
    }

    private void Update()
    {
        //1.Bölüm Topun Hareket Etmesi
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareketEt = new Vector3(yatay, 0, dikey);
        rb.AddForce(hareketEt * hiz);
        //1.Bölüm Topun Hareket Etmesi
    }

    //4.Bölüm Küplerin Yok Edilmesi
    void OnTriggerEnter(Collider kup)
    {
        kup.gameObject.SetActive(false);
        //4.bölüm bitiþ

        //5.Bölüm puanlama ve oyun bitti yazýsý
        puan++;

        puanText.text = "Puan : " + puan;

        if (puan == kupSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
        //5.bölüm bitiþ
    }
}
