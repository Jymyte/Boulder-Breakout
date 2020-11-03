using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDied : MonoBehaviour
{
    public delegate void EndGame();
    public static event EndGame endGame;

    void PlayerDiedEndGame() {
        if(endGame != null) {
            endGame();
        }

        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider target) {
        if(target.tag == "Boulder") {
            PlayerDiedEndGame();
        }
    }
}
