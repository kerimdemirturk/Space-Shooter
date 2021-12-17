using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour

    
{
    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float speed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float eğim;
    float ateşzamanı = 0;
    public  float ateşgeçensüre;
    public GameObject kurşun;
    public Transform kurşunneredençıksın;
    AudioSource kurşunses;
    
    

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        kurşunses = GetComponent<AudioSource>();
        
    }
     void Update()
    {
        
        if(Input.GetButton("Fire1") && Time.time>ateşzamanı)
        {
            ateşzamanı = Time.time + ateşgeçensüre;
            Debug.Log("ateş edildi");
            Instantiate(kurşun, kurşunneredençıksın.position, Quaternion.identity);
            kurşunses.Play();
        }
    }


    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical=Input.GetAxisRaw("Vertical");
        vec = new Vector3(horizontal, 0, vertical);
       
        
            


        fizik.velocity = vec*speed;

        fizik.position = new Vector3
            (
            Mathf.Clamp(fizik.position.x,minX,maxX),
            0.0f,
            Mathf.Clamp(fizik.position.z,minZ,maxZ)
            
            );

        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-eğim);



       

         


    }
}
