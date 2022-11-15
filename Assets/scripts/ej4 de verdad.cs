using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4deverdad : MonoBehaviour
{
    
    private float toplimit = 5;
    private float minlimit = -5;
    private float VerticalSpeed = 3;
    private float velocidadhorizontal = 3;
    private Vector3 direction = Vector3.up;
 
    void Update()
    {

        Vector3 posicionactual = transform.position;
        if (posicionactual.y >= toplimit || posicionactual.y <= minlimit)
            direction.y *= -1;

        float VerticalModSpeed = direction.y > 0 ? VerticalSpeed * 2 : VerticalSpeed;
        direction.x = 1;

        Vector3 velocity = Vector3.zero;
        velocity.x = direction.x * velocidadhorizontal;
        velocity.y = direction.y * VerticalModSpeed;
        Vector3 displacement = velocity * Time.deltaTime;//pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
        transform.position +=  displacement;//actualizo la posicion( translación)

        //clampeo de y =limitacion de las coordenadas de y.
        float clampedYCoord = Mathf.Clamp(posicionactual.y, minlimit, toplimit);
        transform.position = new Vector3(posicionactual.x, clampedYCoord, posicionactual.z);

    }
}