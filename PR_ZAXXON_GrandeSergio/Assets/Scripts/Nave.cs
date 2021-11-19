using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float desplSpeed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 15f;
        rotationSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {


        float desplx = Input.GetAxis("Horizontal");
        float desply = Input.GetAxis("Vertical");
        float desplr = Input.GetAxis("Rotacion");

        float posx = transform.position.x;

        float posy = transform.position.y;

        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplx);
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desply);

        //transform.Rotate(0f, 0f, desplr *Time.deltaTime*-rotationSpeed);

        if (posx > 20f && desplx > 0)
        {
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        }

        if (posx < -20f && desplx < 0)
        {
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        }

        if (posy > 15f && desply > 0)
        {
            transform.position = new Vector3(transform.position.x, posy, transform.position.z);
        }

        if (posy < 0f && desply < 0)
        {
            transform.position = new Vector3(transform.position.x, posy, transform.position.z);
        }
    }

   
    public class selfDestroy : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemigo")
            {
                Destroy(this.gameObject);
            }
        }
       
    }

}
