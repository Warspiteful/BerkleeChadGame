using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class objectPickup : MonoBehaviour
{

    public bool flag; 

    public UnityEvent pickUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            pickUp.Invoke();
            Destroy(gameObject);

        }
    }

}
