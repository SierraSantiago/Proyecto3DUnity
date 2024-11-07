using UnityEngine;

public class HeliceRotacion : MonoBehaviour
{
    public float velocidadRotacion = 300f;

    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadRotacion * Time.deltaTime);
    }
}
