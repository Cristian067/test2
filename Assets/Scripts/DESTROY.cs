using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{

    [SerializeField]private GameObject[] meshParts;
    private AudioSource audioSource;
    [SerializeField] private float yLimit;


    [SerializeField] private GameObject explosion;


    private bool isDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y < yLimit) && !isDead)
        {
            isDead = true; 
            audioSource.Play();
            explosion.active = true;
            meshParts[0].GetComponent<MeshRenderer>().enabled = false;
            meshParts[1].GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            Destroy(gameObject,audioSource.clip.length);
        }
    }



    void OnDestroy()
    {
        
    }
}
