using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float speed=5;
    // Start is called before the first frame update
    void Start()
    {
     /*/ n=23;
      x=234.4f;
      v=new vector3(2,3,1);
      Debug.log(v);
*/

    }

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis= Input.GetAxis("Horizontal");
        
        Vector3 direction=horizontalAxis * Vector3.right + verticalAxis * Vector3.forward;//
        direction.Normalize();
        Vector3 velocity = direction * speed;//pienso en terminos de velocidad por segundo
        Vector3 displacement = velocity * Time.deltaTime;//pienso en velocidad instantanea entre dos espacios de tiempo muy pequeños
        transform.position +=  displacement;//actualizo la posicion( translación)
    }
}
