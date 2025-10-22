using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.forward);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,1) * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,-1,0) *Time.deltaTime*rotateSpeed );
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,1,0) * Time.deltaTime * rotateSpeed);
        }
    }
}
