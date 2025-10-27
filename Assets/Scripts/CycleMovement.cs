using UnityEngine;

public class CycleMovement : MonoBehaviour
{

    public float speed = 0;

    [SerializeField] private Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.forward);

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            transform.position = transform.position + -transform.forward * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        }

        //Transform tans = GameObject.Find("").GetComponent<Transform>();
        
        transform.Rotate(0,Input.GetAxis("Horizontal"),0);
    }
}
