using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolAndString : MonoBehaviour
{
    string isim = "Taha";//string yaz� de�i�kenidir
    string soyisim = "ELEM";
    bool karakteryerde = true;
    string stringtan�m = "string yaz� de�i�kenidir sadece metin karakterleri i�erir.";
    string booltan�m = "bool ise sadece true ve false de�erleri aras�nda ge�i� yapabilir.";
    private void Start()
    {
        karakteryerde = !karakteryerde;
        Debug.Log(isim + " " + soyisim);
        Debug.Log(karakteryerde +" asl�nda "+ !karakteryerde + "'dur");
        Debug.Log(stringtan�m);
        Debug.Log(booltan�m);


    }
}
