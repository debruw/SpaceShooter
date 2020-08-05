using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosionEffect, playerExplosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundry"))
        {
            return;
        }
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosionEffect, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }        
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
