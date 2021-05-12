using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosingTrigger : MonoBehaviour
{

    public GameObject losingPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            losingPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
