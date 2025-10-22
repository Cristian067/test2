using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform targetTransform;
    [SerializeField] private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetTransform.position + offset;

        transform.LookAt(targetTransform.position);
    }
}
