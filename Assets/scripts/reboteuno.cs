using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reboteuno : MonoBehaviour
{
    private float speed=2;
    private float toplimit = 5;
    private float minlimit = -5;

    private Vector3 direction = Vector3.up;
    void Update()
    {

        Vector3 posicionactual = transform.position;
        if (posicionactual.y > toplimit || posicionactual.y < minlimit)
            direction.y *= -1;
        Vector3 velocity = direction * speed;//pienso en terminos de velocidad por segundo
        Vector3 displacement = velocity * Time.deltaTime;//pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
        transform.position +=  displacement;//actualizo la posicion( translación)

    }
}
