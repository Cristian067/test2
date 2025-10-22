using UnityEngine;

public class ControlBehaviour : MonoBehaviour
{

    [SerializeField] private float speed;


    private float horizontal;
    private float vertical;

    private Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (horizontal != 0 || vertical != 0)
        {
            rb.linearVelocity = new Vector3(horizontal, rb.linearVelocity.y, vertical);
        }

    }


    void OnCollisionEnter(Collision collision)
    {
        
    }
}


