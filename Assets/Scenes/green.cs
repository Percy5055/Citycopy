using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    float gtime = 4;
    float dtime = 4;
    float alltime = 10;
    // Start is called before the first frame update
    void Start()
    {
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
            material.color = Color.black;
            GetComponent<MeshRenderer>().material = material;
            InvokeRepeating("TurnGreen", 0f, alltime);
            InvokeRepeating("TurnBlack", dtime, alltime);
    }

    // Update is called once per frame
    void Update(){}
    void TurnGreen(){
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.green;
        GetComponent<MeshRenderer>().material = material1;
    }
     void TurnBlack(){
        Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        material2.color = Color.black;
        GetComponent<MeshRenderer>().material = material2;
    }
}
