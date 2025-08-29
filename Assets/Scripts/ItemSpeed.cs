using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSpeed : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnTrigggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            print("entrou");
        }
          playerMovement.moveSpeed = 10f;
          Destroy(gameObject);
    }
}
