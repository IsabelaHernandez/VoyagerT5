using UnityEngine;

public class Cables : MonoBehaviour
{
    //Isa

    public SpriteRenderer finalCable;
    public GameObject luz, pivot;
    private Vector2 posicionOriginal;
    private Vector2 tamanoOriginal;
    private TareaCables tareaCables;

    void Start()
    {
        posicionOriginal = transform.position;
        tamanoOriginal = finalCable.size;
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
        ActualizarPosicion();
        //ComprobarConexion();
        ActualizarRotacion();
        ActualizarTamano();
    }

    private void ActualizarPosicion()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y);
    }

    private void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 puntoOrigen = pivot.transform.position;
        Vector2 direccion = posicionActual - puntoOrigen;
        float angulo = Vector2.SignedAngle(Vector2.right * transform.lossyScale, direccion);
        transform.rotation = Quaternion.Euler(0, 0, angulo);
        finalCable.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, angulo);
    }

    private void ActualizarTamano()
    {
        var posicionActual = transform.position;
        var puntoOrigen = pivot.transform.position;
        var distancia = Vector2.Distance(posicionActual, puntoOrigen);
        finalCable.size = new Vector2(distancia, finalCable.size.y);
    }

    private void Reiniciar()
    {
        transform.position = posicionOriginal;
        transform.rotation = Quaternion.identity;
        finalCable.size = tamanoOriginal;
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
                    // Conexion correcta.
                    Conectar();
                    otroCable.Conectar();

                    //Apagar Colliders
                    gameObject.GetComponent<Collider2D>().enabled = false;
                    col.GetComponent<Collider2D>().enabled = false;

                    //FindObjectOfType<DragDrop2D>().isDrag = false;

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