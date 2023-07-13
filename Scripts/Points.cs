using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int pointsValue;
    // Start is called before the first frame update
    void Start()
    {
        pointsValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = pointsValue.ToString();
    }
}
