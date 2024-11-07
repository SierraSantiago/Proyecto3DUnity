using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float changeDirectionInterval = 2f;
    public float maxHeight = 22f; // Altura máxima en el eje Y
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("ChangeDirection", 0f, changeDirectionInterval);
    }

    void ChangeDirection()
    {
        // Genera una dirección aleatoria
        Vector3 randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;

        // Si el globito ha alcanzado la altura máxima, invierte la dirección en Y
        if (transform.position.y >= maxHeight && randomDirection.y > 0)
        {
            randomDirection.y = -randomDirection.y;
        }

        // Aplica la fuerza en la dirección aleatoria (con límite en altura)
        rb.AddForce(randomDirection * moveSpeed, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el globito choca con el terreno
        if (collision.gameObject.CompareTag("Terrain"))
        {
            // Refleja la velocidad en la dirección de la colisión para simular un rebote
            Vector3 reflectDir = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectDir;
        }
    }
}
