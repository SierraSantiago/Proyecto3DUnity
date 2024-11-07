using UnityEngine;

public class SeguirAvion : MonoBehaviour
{
    public Transform avion;         // Objeto del avi�n al que queremos seguir
    public Vector3 offset;          // Distancia entre la c�mara y el avi�n

    void Start()
    {
        // Inicializamos el offset seg�n la posici�n inicial de la c�mara
        offset = transform.position - avion.position;
    }

    void LateUpdate()
    {
        // Actualizamos la posici�n de la c�mara para que siga al avi�n
        transform.position = avion.position + offset;
    }
}
