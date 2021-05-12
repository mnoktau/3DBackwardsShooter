using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public bool isGameStarted;

    private Timer timerScript;

    public GameObject Timer;

    private Animator animator_Player;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        isGameStarted = false;

        gameObject.GetComponent<SwipeInput>().enabled = false;

        animator_Player = GetComponent<Animator>();

        timerScript = GameObject.Find("Timer").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(timerScript.countDown < 0 && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(Timer);
            gameObject.GetComponent<SwipeInput>().enabled = true;
        }

        if(isGameStarted && Time.timeScale == 1f)
        {
            transform.position -= transform.forward * 1f * Time.deltaTime;
            animator_Player.SetTrigger("RunBackwards");
        }
        
    }
}
