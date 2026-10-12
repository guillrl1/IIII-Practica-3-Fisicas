using UnityEngine;

public class colisionCambioColor : MonoBehaviour {
    void OnCollisionEnter(Collision collision) {
        Debug.Log(gameObject.name + "Ha colisionado con " + collision.gameObject.name);
        Renderer objectRendererOtro = collision.gameObject.GetComponent<Renderer>();
        if(collision.gameObject.name != "Plane")
        objectRendererOtro.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
