using UnityEngine;

public class Vehicles : MonoBehaviour
{

    public int lives = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {

            Destroy(gameObject);
            
        }
    }

}
