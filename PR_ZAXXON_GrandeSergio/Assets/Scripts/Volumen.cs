using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text volumenText;
    float volumen;
    [SerializeField] Slider mySlider;
    // Start is called before the first frame update
    void Start()
    {
        volumenText.text = "Volumen:" + mySlider.value;


    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SubirVolumen()
    {
        volumen = (mySlider.value);
        volumenText.text = "Volumen:" + volumen;
    }
}
