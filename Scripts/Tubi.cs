using UnityEngine;

public class Tubi : MonoBehaviour
{
    bool alredyCounted = false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameover)
        {
            transform.position = new Vector2
            (
                // Time.deltaTime is the frame time 
                transform.position.x - 2f * Time.deltaTime, // we use this command to have a smooth transition of the floor
                transform.position.y
            );  
        }
        
        if (transform.position.x < -2)
        {
            Destroy(gameObject);
        }

        if (!alredyCounted && transform.position.x < -1)
        {
            audioSource.Play();
            alredyCounted = true;
            Points.pointsValue += 1;
        }
    }
}
