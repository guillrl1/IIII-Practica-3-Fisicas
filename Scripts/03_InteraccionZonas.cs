using UnityEngine;

public class InteraccionZonas : MonoBehaviour {
    public int dmg = 0;
    private Color colorDefault;
    private Renderer rendererPj;

    void Start() {
        rendererPj = GetComponent<Renderer>();
        colorDefault = rendererPj.material.color;
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("ZonaColor")) {
            rendererPj.material.color = new Color(Random.value, Random.value, Random.value);
            Debug.Log("Entrando en zona de efecto. Color cambiado.");
        }
        if(other.CompareTag("ZonaDmg")) {
            dmg++;
            Debug.Log("Entrando en zona de daño. Daño actual: " + dmg);
        }
    }

     void OnTriggerExit(Collider other) {
        if(other.CompareTag("ZonaColor")) {
            rendererPj.material.color = colorDefault;
            Debug.Log("Saliendo de zona de efecto. Color restaurado.");
        }
        if(other.CompareTag("ZonaDmg")) {
            Debug.Log("Saliendo de zona de daño.");
        }
    }
}
