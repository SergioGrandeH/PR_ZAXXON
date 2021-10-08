using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMove : MonoBehaviour
{

    float speed;

    [SerializeField] GameObject initObject;

    InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("InitGame");
        initGame = initObject.GetComponent<InitGame>();

        


    }

    // Update is called once per frame
    void Update()
    {
        
            speed = initGame.NaveSpeed;

            //speed = 20f;
            
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posz = transform.position.z;
        if (posz <-20)
        {
            Destroy(gameObject);
        }
    }
}