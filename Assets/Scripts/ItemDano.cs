using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemDano : MonoBehaviour
{
    public TMP_Text vidaText;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {

            if (gameManager.vida <= 0)
            {
                Debug.Log("Game Over!");
                return;
            }
            else if (gameManager.vida > 0)
            {
                gameManager.Dano(1);
            }
        }
    }
}
