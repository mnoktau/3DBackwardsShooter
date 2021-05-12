using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeInput : MonoBehaviour
{

    private Touch touch;
    [SerializeField]
    float speedModifier = 0.0044f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + -touch.deltaPosition.x * speedModifier);
            }
        }
        
    }
}
