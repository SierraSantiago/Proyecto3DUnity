using UnityEngine;

public class SeguirAvion : MonoBehaviour
{
    public Transform avion;         // Objeto del avión al que queremos seguir
    public Vector3 offset;          // Distancia entre la cámara y el avión

    void Start()
    {
        // Inicializamos el offset según la posición inicial de la cámara
        offset = transform.position - avion.position;
    }

    void LateUpdate()
    {
        // Actualizamos la posición de la cámara para que siga al avión
        transform.position = avion.position + offset;
    }
}
