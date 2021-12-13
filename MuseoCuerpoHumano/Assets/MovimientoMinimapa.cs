using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMinimapa : MonoBehaviour
{
    public Transform playerTransform;
    public Transform mainCamera;
    public float altura = 20.0f;

    private Vector3 normalXZ = new Vector3(0, 1, 0);
    private float posicionYCamara;
  

    private void Start()
    {
        // La cámara del minimapa estará encima del usuario
        // Su posición "Y" solo se inicializa una vez para que
        // no le afecten los saltos del usuario
        posicionYCamara = playerTransform.position.y + altura;
    }

    void LateUpdate()
    {
        // Esto se ejecuta en la cámara del minimapa.
        // Queremos que el minimapa tenga la posición del jugador
        // pero más alto
        Vector3 newPosition = playerTransform.position;
        newPosition.y = posicionYCamara;

        // Por su parte, dicha cámara debe apuntar en la misma
        // dirección que la cámara principal pero siempre hacia abajo
        float newYRotation = mainCamera.eulerAngles.y;
        Quaternion newRotation = Quaternion.Euler(90.0f, newYRotation, 0);

        transform.rotation = newRotation;
        transform.position = newPosition;
    }
}
