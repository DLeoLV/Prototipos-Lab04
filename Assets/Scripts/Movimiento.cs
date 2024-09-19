using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 7.5f;
    public float longitudRaycast = 0.5f;
    public int cantidadDeSaltos = 1;
    public Rigidbody2D cuerpo;

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector2 nuevaPosicion = new Vector2(transform.position.x + movimientoHorizontal * velocidad * Time.deltaTime, transform.position.y);
        transform.position = nuevaPosicion;
        VerificarSuelo();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cantidadDeSaltos > 0)
            {
                Saltar();
                cantidadDeSaltos = cantidadDeSaltos - 1;
            }
        }
    }
    void Saltar()
    {
        cuerpo.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);
    }
    void VerificarSuelo()
    {
        Vector3 posicionRaycast = new Vector3(transform.position.x, transform.position.y - 0.75f, transform.position.z);
        RaycastHit2D hit = Physics2D.Raycast(posicionRaycast, Vector2.down, longitudRaycast);
        if (hit.collider != null)
        {
            cantidadDeSaltos = 1;
        }
    }
    void OnDrawGizmos()
    {
        Vector3 posicionRaycast = new Vector3(transform.position.x, transform.position.y - 0.75f, transform.position.z);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(posicionRaycast, posicionRaycast + Vector3.down * longitudRaycast);
    }
}