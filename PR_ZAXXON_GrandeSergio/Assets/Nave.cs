using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float desplSpeed;
    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {


        float desplx = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed*desplx);

        float desply = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desply);



    }
}
