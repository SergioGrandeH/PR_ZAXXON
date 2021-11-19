using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour

{
    [SerializeField] Text Score_Text;
    float Punt = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Score");
    }

    // Update is called once per frame
    void Update()
    {

    }
    //IEnumerator Score();
    //{
      //  while (true)
      //  {
       // Score_Text.tex = " " + GameManager.Punt++;
        //}
}
