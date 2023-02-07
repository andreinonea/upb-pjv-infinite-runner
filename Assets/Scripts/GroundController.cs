using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    GameStateManager state;

    [SerializeField]
    List<GameObject> pointObjects;

    [SerializeField]
    List<GameObject> obstacleObjects;

    Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.Find("GameManager").GetComponent<GameStateManager>();

        float length = 100.0f;
        float zStart = transform.position.z - (length / 2);
        float laneStep = 2.5f;

        for (int i = 5; i <= 100; i+=5)
        {
            int rand = Random.Range(0, 100);

            if (rand < 70)
                continue;

            int lane = Random.Range(-1, 2);

            if (rand < 85)
            {
                GameObject coin = Instantiate(obstacleObjects[0], transform, true);
                coin.transform.Translate(new Vector3(lane * laneStep, 0.0f, zStart + (float)i));
            }
            else
            {
                GameObject coin = Instantiate(pointObjects[0], transform, true);
                coin.transform.Translate(new Vector3(lane * laneStep, 0.0f, zStart + (float) i));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement.z = -state.GetGameSpeed() * Time.deltaTime;

        transform.Translate(movement);
    }
}
