using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject meteorPre;

    [SerializeField] private float height;
    [SerializeField] private Vector3 minPos;
    [SerializeField] private Vector3 maxPos;

    [SerializeField] private float timeBetweenSpawn;

    [SerializeField] private float despawnTime;

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

        Vector3 randomPos = new Vector3(Random.Range(minPos.x, maxPos.x), height, Random.Range(minPos.z, maxPos.z));

        GameObject meteor = Instantiate(meteorPre, randomPos, meteorPre.transform.rotation);


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

public class AiSpawner : MonoBehaviour
{

    [SerializeField] private GameObject meteorPre;

    [SerializeField] private float height;
    [SerializeField] private Vector3 minPos;
    [SerializeField] private Vector3 maxPos;

    [SerializeField] private float timeBetweenSpawn;

    [SerializeField] private float despawnTime;

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

        Vector3 randomPos = new Vector3(Random.Range(minPos.x, maxPos.x), height, Random.Range(minPos.z, maxPos.z));

        GameObject meteor = Instantiate(meteorPre, randomPos, meteorPre.transform.rotation);
        

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
