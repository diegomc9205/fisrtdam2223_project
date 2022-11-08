using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class reboteuno : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5;
    private float a = 0;

    void Start()

    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position[1] < 5 && a = 0)
        {
            ;
            Vector3 Vector3.right + verticalAxis * Vector3.forward; //piensa en la direccion
            direction.Normalize();
            Vector3 velocity = direction * speed; //pienso en terminos de velocidad por segundo
            Vector3
                displacement =
                    velocity * Time
                        .deltaTime; //pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
            transform.position += displacement; //actualizo la posicion( translación)
        }
        else
        {
            a = 1;
        }

        if (transform.position[1]>)
        {
            
        }
    }
}