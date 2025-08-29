using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int dinheiro;
    public int vida;
    public TMP_Text dinheiroText;
    public TMP_Text vidaText;

    void Start()
    {
        dinheiro = 0;
        vida = 1;
    }
    public void Adicionar(int valor)
    {
        dinheiro += valor;
        dinheiroText.text = "Dinheiro: " + dinheiro.ToString();
    }

    public void Cura(int life)
    {
        vida += life;
        vidaText.text = " " + vida.ToString();

    }

    public void Dano(int life)
    {
        vida -= life;
        vidaText.text = " " + vida.ToString();

    }


}