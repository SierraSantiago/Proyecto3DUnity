using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAvion : MonoBehaviour
{

    public float VelocidadDeVuelo = 5;
    public float CantidadDeYaw = 120;

    private float Yaw;

    // Update se llama una vez por cuadro
    void Update()
    {

        // mover hacia adelante
        transform.position += transform.forward * VelocidadDeVuelo * Time.deltaTime;

        // entradas
        float entradaHorizontal = Input.GetAxis("Horizontal");
        float entradaVertical = Input.GetAxis("Vertical");

        // yaw, pitch, roll
        Yaw += entradaHorizontal * CantidadDeYaw * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(entradaVertical)) * Mathf.Sign(entradaVertical);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(entradaHorizontal)) * -Mathf.Sign(entradaHorizontal);

        // aplicar rotación
        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);
    }
}
