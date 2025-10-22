//using Unity.Mathematics;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{

    public GameObject tree;

    public Transform targetTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(0, 20);
        
        float randomY = Random.Range(0, 20);


        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(tree,targetTransform.position,Quaternion.identity, targetTransform);
        }
    }
}
