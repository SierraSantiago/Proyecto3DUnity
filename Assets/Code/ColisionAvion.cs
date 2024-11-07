using UnityEngine;

public class ColisionAvion : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el avión chocó contra el terreno
        if (collision.gameObject.CompareTag("Terrain") || collision.gameObject.CompareTag("Balloon"))
        {
            // Destruye el avión
            Destroy(gameObject);
        }
    }
}
