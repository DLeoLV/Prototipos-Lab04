using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int vida = 10;
    public int monedas = 0;
    public string color = "Blanco";

    public void Daño()
    {
        vida = vida - 1;
    }
    public void Cura()
    {
        vida = vida + 1;
    }
    public void Puntos()
    {
        monedas = monedas + 1;
    }
    public void CambiarColor(string nuevoColor)
    {
        color = nuevoColor;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Vida")
        {
            Cura();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Moneda")
        {
            Puntos();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag != color && collision.gameObject.tag != "Blanco")
        {
            Daño();
        }
    }
}
