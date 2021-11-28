using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

	// Update is called once per frame
	void Update ()
    {
        scoreText.text = player.position.z.ToString("0");
        if (player.position.z >= 50 && player.position.z <= 70)
            scoreText.text = player.position.z.ToString("You'r doing great!");
        else if (player.position.z >= 130 && player.position.z <= 150)
            scoreText.text = player.position.z.ToString("Awsome!");
        else if (player.position.z >= 200 && player.position.z <= 220)
            scoreText.text = player.position.z.ToString("INSANE!");
    }
}
