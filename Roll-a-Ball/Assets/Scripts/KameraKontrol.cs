using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    //2.B�l�m Kameran�n Topu Takip Etmesi 
    public GameObject top;
    public Vector3 aradakiFark;
    void Start()
    {
        aradakiFark = this.transform.position - top.transform.position;
    }

    void Update()
    {
        this.transform.position = top.transform.position + aradakiFark;
    }
    //2.B�l�m Kameran�n Topu Takip Etmesi biti�
}
