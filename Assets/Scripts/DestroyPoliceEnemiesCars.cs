using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class DestroyPoliceEnemiesCars : MonoBehaviour
{

    public List<GameObject> policeCars = new List<GameObject>();

    public GameObject camionAzul;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(camionAzul);

            Instantiate(camionAzul);
            foreach (GameObject car in policeCars)
            {
                if (car.transform.position.z > 0)
                {
                    //policeCars.Remove(car);
                    Destroy(car);
                    //
                }

            }
        }
    }


    private IEnumerator PausedDestroy(GameObject target)
    {
        yield return new WaitForSeconds(1);
    }

}
