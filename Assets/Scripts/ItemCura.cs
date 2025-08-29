using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCura : MonoBehaviour
{
    public TMP_Text vidaText;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {

            if (gameManager.vida > 4)
            {
                return;
            }
            else
            {
                gameManager.Cura(1);

            }
        }
    }
}
