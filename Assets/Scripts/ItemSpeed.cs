using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSpeed : MonoBehaviour
{
    private bool Ativado = false;
    public PlayerMovement velocidadeJ;
    public ParticleSystem efeitoV;
    private void onTrigggerEnter2D(Collider2D other)
    {
        Ativado = true;
        if(Ativado == true)
        {
            velocidadeJ.runSpeed = 100f;
            Instantiate(efeitoV, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
