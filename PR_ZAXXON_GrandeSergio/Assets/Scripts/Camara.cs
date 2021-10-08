using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
   
{
    
    [SerializeField] Transform player;
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] GameObject playerObject;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    [SerializeField] Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + 1, playerPosition.position.z - 15);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
