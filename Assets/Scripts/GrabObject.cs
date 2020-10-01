using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{

    public GameObject bola;
    public GameObject tangan;
    public GameObject telapakTangan;

    bool tertangkap = false;
    Vector3 posBola;
    void Start()
    {
        posBola = bola.transform.position;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(!tertangkap){
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(telapakTangan.transform.localPosition.x + 0f, 
                    telapakTangan.transform.localPosition.y + (-.1f), telapakTangan.transform.localPosition.z + 1f);
                bola.GetComponent<Renderer>().material.color = Color.blue;
                tertangkap = true;
            }else{
                bola.transform.SetParent(null);
                bola.transform.localPosition = posBola;
                bola.GetComponent<Renderer>().material.color = Color.red;
                tertangkap = false;
            }
        }
    }
}
