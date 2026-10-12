using UnityEngine;

public class Lanzador : MonoBehaviour {
    public float fuerza = 10f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.X))
            rb.AddForce(Vector3.forward * fuerza, ForceMode.Impulse);
    }
}
