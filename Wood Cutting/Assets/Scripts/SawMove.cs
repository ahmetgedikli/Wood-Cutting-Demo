using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SawMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 position;
    public Text textObject;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                Vector3 touchPosWorld =touch.position;
                if (touchPosWorld.x>300)
                {
                    transform.Translate(5f * Time.deltaTime, 0, 0);
                }
                else if (touchPosWorld.x<300)
                {
                    transform.Translate(- 5f* Time.deltaTime, 0, 0);
                }
            }
        }
    }
}
