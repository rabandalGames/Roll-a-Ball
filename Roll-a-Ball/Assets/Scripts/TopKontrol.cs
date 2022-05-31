using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    //1.b�l�m Topun Hareket Etmesi
    public Rigidbody rb; //Rigidbody s�n�f�ndan bir de�i�ken olu�turuyoruz. Ad� : rb
    public int hiz; //topun hareket etmesi i�in public (unity'de g�r�nen) de�i�ken yarat�yoruz.
    //1.b�l�m biti� Topun Hareket Etmesi

    //5.b�l�m puanlama 
    public int puan; 
    public int kupSayisi;

    public Text puanText;
    public Text oyunBittiText;
    //5.b�l�m puanlama

    void Start()
    {
        //1.b�l�m Topun Hareket Etmesi
        rb = GetComponent<Rigidbody>();
        //1.b�l�m Topun Hareket Etmesi
    }

    private void Update()
    {
        //1.B�l�m Topun Hareket Etmesi
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareketEt = new Vector3(yatay, 0, dikey);
        rb.AddForce(hareketEt * hiz);
        //1.B�l�m Topun Hareket Etmesi
    }

    //4.B�l�m K�plerin Yok Edilmesi
    void OnTriggerEnter(Collider kup)
    {
        kup.gameObject.SetActive(false);
        //4.b�l�m biti�

        //5.B�l�m puanlama ve oyun bitti yaz�s�
        puan++;

        puanText.text = "Puan : " + puan;

        if (puan == kupSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
        //5.b�l�m biti�
    }
}
