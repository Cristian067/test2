using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class BombBehavior : MonoBehaviour
{

    private Rigidbody rb;
    private AudioSource ass;

    [SerializeField] private GameObject[] explosions;
    
    [SerializeField]private GameObject[] childs;

    private bool onAir = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ass = GetComponent<AudioSource>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rb.linearVelocity);

        if (onAir)
        {
            rb.linearVelocity += new Vector3(0, -0.1f, 0);
        }
    }

    private void Kaboom(GameObject target)
    {
        if (target.tag == "Vehicle")
        {
            explosions[0].active = true;
            target.GetComponent<Vehicles>().LoseLife();
        }
        else if (target.tag == "Building")
        {
            explosions[1].active = true;
            Destroy(target);
        }
        else if (target.tag != "Ground")
        {
            explosions[1].active = true;
            Destroy(target);
        }

        else
        {
            explosions[0].active = true;
        }
        foreach (var child in childs)
        {
            Destroy(child);
        }

        ass.Play();
        Destroy(gameObject,9);
    }



    void OnCollisionEnter(Collision collision)
    {
        onAir = false;
        Kaboom(collision.gameObject);
       // Debug.Log("Enter");
    }


    void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Stay");
    }

    void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Exit");
    }
}
