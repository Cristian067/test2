using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject meteorPre;

    [SerializeField] private float height;
    [SerializeField] private Vector3 minPos;
    [SerializeField] private Vector3 maxPos;

    [SerializeField] private float timeBetweenSpawn;

    [SerializeField] private float despawnTime;


    [SerializeField] private float bombsToTrack;
    [SerializeField] private float bombCountToTrack;

    [SerializeField] private List<GameObject> targets;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnMeteor", 0, timeBetweenSpawn);

    }

    // Update is called once per frame
    void Update()
    {



    }



    private void SpawnMeteor()
    {

        Vector3 spawnPos;

        bombCountToTrack++;

        if(bombCountToTrack >= bombsToTrack)
        {
            foreach(GameObject target in GameObject.FindGameObjectsWithTag("Building"))
            {
                targets.Add(target);
            }
            foreach (GameObject target in GameObject.FindGameObjectsWithTag("Vehicle"))
            {
                targets.Add(target);
            }
            foreach (GameObject target in GameObject.FindGameObjectsWithTag("OfficialVehicle"))
            {
                targets.Add(target);
            }

            Transform targetToKill = targets[Random.Range(0, targets.Count)].transform;
            spawnPos = new Vector3(targetToKill.position.x,height,targetToKill.position.z);
            targets.Clear();
            bombCountToTrack = 0;


        }
        else
        {
            spawnPos = new Vector3(Random.Range(minPos.x, maxPos.x), height, Random.Range(minPos.z, maxPos.z));
        }
            

        GameObject meteor = Instantiate(meteorPre, spawnPos, meteorPre.transform.rotation);


        StartCoroutine(DestroyMeteor(meteor));

    }




    private IEnumerator DestroyMeteor(GameObject meteorgo)
    {

        if (meteorgo != null)
        {
            yield return new WaitForSeconds(despawnTime);
            Destroy(meteorgo);
        }


    }

}


