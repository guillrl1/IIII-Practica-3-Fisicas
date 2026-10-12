using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 5, -10); // Ajusta la posición relativa

    void LateUpdate()
    {
        if (player != null)
        {
            // Mantiene la posición relativa sin girar con el jugador
            transform.position = player.position + offset;
            
            // Opcional: Haz que la cámara mire siempre al jugador
            transform.LookAt(player);
        }
    }
}   