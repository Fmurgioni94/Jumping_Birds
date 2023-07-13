using UnityEngine;

public class Bird : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restartButton;
    public AudioClip[] audioClips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameController.gameover)
        {
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, 6f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.gameover = true;
        audioSource.PlayOneShot(audioClips[1]);
        gameover.SetActive(true);
        restartButton.SetActive(true);
    }
}
