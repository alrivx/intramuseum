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
        // La c�mara del minimapa estar� encima del usuario
        // Su posici�n "Y" solo se inicializa una vez para que
        // no le afecten los saltos del usuario
        posicionYCamara = playerTransform.position.y + altura;
    }

    void LateUpdate()
    {
        // Esto se ejecuta en la c�mara del minimapa.
        // Queremos que el minimapa tenga la posici�n del jugador
        // pero m�s alto
        Vector3 newPosition = playerTransform.position;
        newPosition.y = posicionYCamara;

        // Por su parte, dicha c�mara debe apuntar en la misma
        // direcci�n que la c�mara principal pero siempre hacia abajo
        float newYRotation = mainCamera.eulerAngles.y;
        Quaternion newRotation = Quaternion.Euler(90.0f, newYRotation, 0);

        transform.rotation = newRotation;
        transform.position = newPosition;
    }
}
