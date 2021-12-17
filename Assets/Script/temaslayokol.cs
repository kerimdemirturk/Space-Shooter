using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslayokol : MonoBehaviour
{

    GameObject oyunkontrol;
    oyunkontrol kontrol;
     void Start()
    {
        oyunkontrol = GameObject.FindGameObjectWithTag("Oyunkontrol");                       
        kontrol = oyunkontrol.GetComponent<oyunkontrol>();
        
            

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sınır")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            kontrol.skorarttır(10);

            
            
        }
        if(col.tag=="Player")
        {
            kontrol.gameover();
        }

        
        
            
        
    }
    







}
