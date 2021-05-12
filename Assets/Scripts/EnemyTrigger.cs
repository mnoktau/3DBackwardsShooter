using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{

    public ParticleSystem confettiEnemy;
    public GameObject confettiEnemy_Object;
    public GameObject enemy;
    public GameObject enemyMesh;
    public Collider enemyCollider;
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
        if(other.gameObject.CompareTag("Bullet"))
        {

            StartCoroutine(EnemyDestroy());

        }
    }

    IEnumerator EnemyDestroy()
    {
        confettiEnemy_Object.SetActive(true);
        confettiEnemy.Play();
        enemyMesh.SetActive(false);
        enemyCollider.enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(enemy);


    }
}
