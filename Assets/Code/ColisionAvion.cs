using UnityEngine;

public class ColisionAvion : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el avi�n choc� contra el terreno
        if (collision.gameObject.CompareTag("Terrain") || collision.gameObject.CompareTag("Balloon"))
        {
            // Destruye el avi�n
            Destroy(gameObject);
        }
    }
}
