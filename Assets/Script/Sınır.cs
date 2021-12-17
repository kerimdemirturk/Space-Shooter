using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sınır : MonoBehaviour
{
    void OnTriggerExit(Collider coll)
    {
        Destroy(coll.gameObject);
    }
}
