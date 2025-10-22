using UnityEngine;

public class JumpPlatfoemBehavior : MonoBehaviour
{

    [SerializeField] private float jumpForce;



    [SerializeField] private bool go;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (go)
        {
            Yes();
        }
    }


    private void Yes()
    {
        transform.Translate(new Vector3(0, 2, 0)*Time.deltaTime * jumpForce);
    }

    void OnTriggerEnter(Collider other)
    {
        //go = true;
        
            

             Rigidbody targetRb = other.gameObject.GetComponent<Rigidbody>();
            targetRb.AddForce(new Vector3(0, 1, 0) * jumpForce);


        
    }
}
