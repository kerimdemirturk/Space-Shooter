﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroidhareket : MonoBehaviour
{
    Rigidbody fizik;
    public float speed;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * speed;
    }
    

}
