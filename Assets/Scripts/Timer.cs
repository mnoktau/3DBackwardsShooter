using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text countDown_Text;

    public float countDown = 3f;
    // Start is called before the first frame update
    void Start()
    {
        countDown_Text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        countDown_Text.text = "" + Mathf.Round(countDown);

        

    }
}
