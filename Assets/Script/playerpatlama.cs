using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpatlama : MonoBehaviour
{
    public class DestroyPlayer : MonoBehaviour
    {
        void OnCollisionEnter(Collision col)

        {
            if (col.gameObject.CompareTag("Obstacle"))

            {
                Destroy(gameObject);
            }
        }

    }
}