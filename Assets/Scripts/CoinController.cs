using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    GameStateManager state;
    readonly int value = 1;

    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.Find("GameManager").GetComponent<GameStateManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        state.AddScore(value);
    }
}
