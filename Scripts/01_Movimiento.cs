using UnityEngine;

public class Movimiento : MonoBehaviour {
    public float velocidad = 5f;
    private Rigidbody rb;
    private Vector3 movimiento;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        float movimientoX = Input.GetAxisRaw("Horizontal");
        float movimientoZ = Input.GetAxisRaw("Vertical");
        // Para que no se mueva mas rapido en diagonal
        movimiento = new Vector3(movimientoX, 0f, movimientoZ).normalized;
    }

    void FixedUpdate() {
        rb.MovePosition(transform.position + movimiento * Time.fixedDeltaTime * velocidad);
    }
}
