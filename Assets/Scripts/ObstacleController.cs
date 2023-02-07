using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameStateManager state;

    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.Find("GameManager").GetComponent<GameStateManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        state.GameOver();
    }
}
