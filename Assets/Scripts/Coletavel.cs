using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int dinheiro = 10;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D Objeto)
    {
        if (Objeto.CompareTag("Player")) { 
            gameManager.Adicionar(dinheiro);
        }
    }
}
