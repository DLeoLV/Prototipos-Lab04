using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorTexto : MonoBehaviour
{
    public TextMeshProUGUI vidaText;
    public TextMeshProUGUI monedasText;
    public TextMeshProUGUI colorText;
    public Jugador jugador;

    void Start()
    {
        ActualizarVida();
    }
    void Update()
    {
        ActualizarVida();
    }

    public void ActualizarVida()
    {
        vidaText.text = "Vida: " + jugador.vida;
        monedasText.text = "Monedas: " + jugador.monedas;
        colorText.text = "Color: " + jugador.color;
    }
}