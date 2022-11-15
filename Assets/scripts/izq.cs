using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1º A la izquierda te mueves al doble de rapidez que a la derecha con input de usuario.
public class izq : MonoBehaviour
{
    // Start is called before the first frame update
 private float speed=5;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");// para moverse con w y s
        float horizontalAxis= Input.GetAxis("Horizontal");//moverse con a y d
        //vector3.forward es para profundidad.
        Vector3 direction=horizontalAxis * Vector3.right + verticalAxis * Vector3.forward;//piensa en la direccion
        direction.Normalize();
        if ( direction.x<0)
        direction*=2;
        Vector3 velocity = direction * speed;//pienso en terminos de velocidad por segundo
        Vector3 displacement = velocity * Time.deltaTime;//pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
        transform.position +=  displacement;//actualizo la posicion( translación)
        
        
    }
}
