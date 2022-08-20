using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyunbitme : MonoBehaviour
{
   /* public GameObject karakter;
    public GameObject karakter;*/
    public GameObject karakter;
    KarakterScript Karakters;
    public GameObject olmeekran;
    public float mesafe;
    void Start()
    {
        Karakters = karakter.transform.gameObject.GetComponent<KarakterScript>();
    }


    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag=="Player")
        {
            Debug.Log("Carptýn");
           // mesafe = Vector3.Distance(transform.position, karakter.transform.position);
            if (Karakters.ilacsayýsý > 3 && Karakters.ilkyardýmkits > 4 && Karakters.snipermermikutu > 3 && Karakters.snipermermikutu > 4)
            {
                
                    olmeekran.SetActive(true);
                
            }
            else
            {

            }
        }

    }
}
