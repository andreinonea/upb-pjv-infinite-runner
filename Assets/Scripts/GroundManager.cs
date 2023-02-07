using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> groundObjects;

    GameObject currGround;
    GameObject nextGround;

    // Start is called before the first frame update
    void Start()
    {
        currGround = Instantiate(groundObjects[0], groundObjects[0].transform, true);
        nextGround = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextGround == null && currGround.transform.position.z < 30.0f)
        {
            nextGround = Instantiate(groundObjects[0], groundObjects[0].transform, true);
            nextGround.transform.Translate(currGround.transform.position + groundObjects[0].transform.position);
        }
        if (nextGround != null && nextGround.transform.position.z < groundObjects[0].transform.position.z)
        {
            Destroy(currGround);
            currGround = nextGround;
            nextGround = null;
        }
    }
}
