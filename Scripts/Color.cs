using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public Color colorDeseado = Color.white;

    void Start() {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null && rend.material != null) {
            rend.material.color = colorDeseado;
        }
    }
}