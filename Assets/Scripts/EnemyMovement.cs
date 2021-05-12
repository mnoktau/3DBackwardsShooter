using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public PlayerManager playerManager;

    [SerializeField]
    float enemySpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerManager.isGameStarted && Time.timeScale == 1f)
        {

            transform.position += transform.forward * enemySpeed * Time.deltaTime;

        }
        
    }
}
