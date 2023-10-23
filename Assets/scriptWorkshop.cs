using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptWorkshop : MonoBehaviour
{
    public GameObject sphere;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        sphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);   

   
        
    }
}
