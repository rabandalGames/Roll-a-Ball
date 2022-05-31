using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupKontrol : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        //3.bölüm küplerin dönüþ þekli
        Vector3 donusHizi = new Vector3(15, 30, 45);
        transform.Rotate(donusHizi * 0.005f);
    }
}
