using UnityEngine;

public class MovimientoSinFisicas : MonoBehaviour
{
    public Transform objetivo;     // El cilindro hacia donde vamos
    public Transform obstaculo;    // El cubo que está en medio
    public float velocidad = 3f;   // Velocidad de movimiento
    
    private Renderer rendererCubo;
    private bool yaColisiono = false;

    void Start() {
        rendererCubo = obstaculo.GetComponent<Renderer>();
    }

    void Update(){
        // MoveTowards desplaza el objeto desde su posición actual hacia la posición del objetivo a una velocidad constante
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);

        // Calculamos la distancia entre el centro de la esfera y el centro del cubo
        if (!yaColisiono && obstaculo != null) {
            float distancia = Vector3.Distance(transform.position, obstaculo.position);
            
            // Si la distancia entre sus centros 
            // es menor a 1 (0.5 de radio de esfera + 0.5 de mitad del cubo), significa que se están tocando.
            if (distancia <= 1.0f) {
                CambiarMaterialCubo();
            }
        }
    }

    void CambiarMaterialCubo() {
        yaColisiono = true; // Para que no cambie el color todos los frames
        rendererCubo.material.color = Color.red; 
        Debug.Log("La esfera alcanzó al cubo.");
    }
}