using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawn : MonoBehaviour
{

    public GameObject pedestrianPrefab1;
    public GameObject pedestrianPrefab2;
    public GameObject pedestrianPrefab3;
    public GameObject pedestrianPrefab4;
    public GameObject pedestrianPrefab5;

    public int pedestriansToSpawn1;
    public int pedestriansToSpawn2;
    public int pedestriansToSpawn3;
    public int pedestriansToSpawn4;
    public int pedestriansToSpawn5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        int count = 0;
        while (count < pedestriansToSpawn1)
        {
            GameObject obj = Instantiate(pedestrianPrefab1);
            Transform child = transform.GetChild(Random.Range(0,transform.childCount - 1));
            obj.GetComponent<CWAY>().currentWaypoint = child.GetComponent<Waypoint>();
            obj.transform.position = child.position;

            yield return new WaitForEndOfFrame();

            count++;
        }

        count=0;
        while (count < pedestriansToSpawn2)
        {
            GameObject obj = Instantiate(pedestrianPrefab2);
            Transform child = transform.GetChild(Random.Range(0,transform.childCount - 1));
            obj.GetComponent<CWAY>().currentWaypoint = child.GetComponent<Waypoint>();
            obj.transform.position = child.position;

            yield return new WaitForEndOfFrame();

            count++;
        }

        count=0;
        while (count < pedestriansToSpawn3)
        {
            GameObject obj = Instantiate(pedestrianPrefab3);
            Transform child = transform.GetChild(Random.Range(0,transform.childCount - 1));
            obj.GetComponent<CWAY>().currentWaypoint = child.GetComponent<Waypoint>();
            obj.transform.position = child.position;

            yield return new WaitForEndOfFrame();

            count++;
        }

        count=0;
        while (count < pedestriansToSpawn4)
        {
            GameObject obj = Instantiate(pedestrianPrefab4);
            Transform child = transform.GetChild(Random.Range(0,transform.childCount - 1));
            obj.GetComponent<CWAY>().currentWaypoint = child.GetComponent<Waypoint>();
            obj.transform.position = child.position;

            yield return new WaitForEndOfFrame();

            count++;
        }

        count=0;
        while (count < pedestriansToSpawn5)
        {
            GameObject obj = Instantiate(pedestrianPrefab5);
            Transform child = transform.GetChild(Random.Range(0,transform.childCount - 1));
            obj.GetComponent<CWAY>().currentWaypoint = child.GetComponent<Waypoint>();
            obj.transform.position = child.position;

            yield return new WaitForEndOfFrame();

            count++;
        }
        
    }
}
