using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    float gtime = 4;
    float dtime = 6;
    float alltime = 10;
    // Start is called before the first frame update
    void Start()
    {
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
            material.color = Color.black;
            GetComponent<MeshRenderer>().material = material;
            InvokeRepeating("TurnRed", 6f, alltime);
            InvokeRepeating("TurnBlack", 0, alltime);
    }

    // Update is called once per frame
    void Update(){}
    void TurnRed(){
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.red;
        GetComponent<MeshRenderer>().material = material1;
    }
     void TurnBlack(){
        Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        material2.color = Color.black;
        GetComponent<MeshRenderer>().material = material2;
    }
}
