using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    public float rapidezDesplazamiento = 10.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Moverse hacia la izquierda y la derecha
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, 0);

        float movimientoVertical = Input.GetAxis("Vertical") * rapidezDesplazamiento;

        movimientoVertical *= Time.deltaTime;

        transform.Translate(0, 0, movimientoVertical);
    }
}