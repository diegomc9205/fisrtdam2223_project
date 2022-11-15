using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5 : MonoBehaviour
{
    private float vel = 2;
    private float limitd = 10;
    private float limiti = -10;
    private float toplimit = 5;
    private float minlimit = -5;

    
    private Vector3 direction = Vector3.one;//1,1,1 de vectores
    
    void Update()
    {

        Vector3 posicionactual = transform.position;
        if (posicionactual.y >= toplimit || posicionactual.y <= minlimit)
            direction.y *= -1;
        if (posicionactual.x >= limitd || posicionactual.x <= limiti)
            direction.x *= -1;
        
      

        Vector3 velocity = Vector3.zero;// la velocidad la pongo a 0
        velocity.x = direction.x * vel;//damos celocidad a x 
        velocity.y = direction.y * vel;//damos vel a y
        Vector3 displacement = velocity * Time.deltaTime;//pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
        transform.position +=  displacement;//actualizo la posicion( translación)

        //clampeo de y =limitacion de las coordenadas de y.
        float clampedYCoord = Mathf.Clamp(posicionactual.y, minlimit, toplimit);
        float clampedXCoord = Mathf.Clamp(posicionactual.x, limiti, limitd); 
        transform.position = new Vector3(clampedXCoord, clampedYCoord, posicionactual.z);       
    }
}