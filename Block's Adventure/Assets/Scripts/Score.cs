using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public bool stopScore = false;

    // Update is called once per frame
    void Update()
    {
        if (stopScore == false)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
