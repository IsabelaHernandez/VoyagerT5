using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cables : MonoBehaviour
{ //Isa

    public SpriteRenderer finalCable;
    public GameObject luz;

    private Vector2 posicionOriginal;
    private Vector2 tama�oOriginal;
    private TareaCables tareaCables;

    void Start()
    {
        posicionOriginal = transform.position;
        tama�oOriginal = finalCable.size;
        tareaCables = transform.root.gameObject.GetComponent<TareaCables>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Reiniciar();
        }
    }

    private void OnMouseDrag()
    {
       // ActualizarPosicion();
        ComprobarConexion();
        ActualizarRotacion();
        ActualizarTama�o();
    }

    private void ActualizarPosicion()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y);
    }

    private void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 puntoOrigen = transform.parent.position;

        Vector2 direccion = posicionActual - puntoOrigen;

        float angulo = Vector2.SignedAngle(Vector2.right * transform.lossyScale, direccion);

        transform.rotation = Quaternion.Euler(0, 0, angulo);
    }

    private void ActualizarTama�o()
    {
        Vector2 posicionActual = transform.position;
        Vector2 puntoOrigen = transform.parent.position;

        float distancia = Vector2.Distance(posicionActual, puntoOrigen);

        finalCable.size = new Vector2(distancia, finalCable.size.y);
    }

    private void Reiniciar()
    {
        transform.position = posicionOriginal;
        transform.rotation = Quaternion.identity;
        finalCable.size = tama�oOriginal;
    }

    private void ComprobarConexion()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.2f);

        foreach (Collider2D col in colliders)
        {
            // No procesamos el collider del cable que estamos moviendo.
            if (col.gameObject != gameObject)
            {
                transform.position = col.transform.position;

                Cables otroCable = col.gameObject.GetComponent<Cables>();

                if (finalCable.color == otroCable.finalCable.color)
                {
                    // Conexi�n correcta.
                    Conectar();
                    otroCable.Conectar();

                    tareaCables.conexionesActuales++;
                    tareaCables.ComprobarVictoria();
                }

               
            }
        }
    }

    public void Conectar()
    {
        luz.SetActive(true);
        Destroy(this);
    }
}