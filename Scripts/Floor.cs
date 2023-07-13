using UnityEngine;

public class Floor : MonoBehaviour
{
    Vector2 startingPoint;
    // Start is called before the first frame update
    void Start()
    {
        startingPoint = transform.position; // take the position of the object
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameover)
        {
            if (transform.position.x >= -0.76f)
                transform.position = new Vector2
                (
                    // Time.deltaTime is the frame time 
                    transform.position.x - 2f * Time.deltaTime, // we use this command to have a smooth transition of the floor
                    transform.position.y
                );
            else
                transform.position = startingPoint;
        }
        
    }
}
