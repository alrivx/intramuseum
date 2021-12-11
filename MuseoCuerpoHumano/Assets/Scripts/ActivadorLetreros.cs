using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorLetreros : MonoBehaviour
{
    public GameObject[] areaActivacion;
    public GameObject[] letreros;
    public AudioClip audioAparicion;

    void OnTriggerEnter(Collider otherObject)
    {
        for (int i = 0; i < areaActivacion.Length; ++i)
        {
            if (otherObject.gameObject == areaActivacion[i])
            {
                letreros[i].SetActive(true);
                AudioSource.PlayClipAtPoint(audioAparicion, otherObject.transform.position);
            }
        }
    }

    void OnTriggerExit(Collider otherObject)
    {
        for (int i = 0; i < areaActivacion.Length; ++i)
        {
            if (otherObject.gameObject == areaActivacion[i])
            {
                letreros[i].SetActive(false);
            }
        }
    }
}
