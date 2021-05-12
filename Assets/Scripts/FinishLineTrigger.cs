using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    public GameObject confetti;
    public ParticleSystem confetti_particle;
    public GameObject win_panel;
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
        if(other.gameObject.CompareTag("Player"))
        {
            confetti_particle.Play();
            confetti.SetActive(true);
            win_panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
