using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    // Start is called before the first frame update

    public void beginGame ()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        scoreManager.activeGame = true;
        scoreManager.points = 0;
        scoreManager.blockHealthScore = 100;
        scoreManager.playerHealthScore = 100;
    }
}
