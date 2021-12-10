using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorLetreros : MonoBehaviour
{
    public GameObject[] areaActivacion;
    public GameObject[] letreros;

    void OnTriggerEnter(Collider otherObject)
    {
        for (int i = 0; i < areaActivacion.Length; ++i)
        {
            if (otherObject.gameObject == areaActivacion[i])
            {
                letreros[i].SetActive(true);
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
