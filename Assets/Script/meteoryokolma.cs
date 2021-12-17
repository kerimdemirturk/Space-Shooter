using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoryokolma : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag!="sınır")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
