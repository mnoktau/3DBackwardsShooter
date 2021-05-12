using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float thrust = 1.0f;

    public GameObject bullet;
    public Transform transform_Parent;
    public Transform transform_Child;

    [SerializeField]
    float waitforOnce = 3.2f;

    [SerializeField]
    float waitforSecond = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        bullet.SetActive(false);
        StartCoroutine(BulletShoots());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator BulletShoots()
    {

        yield return new WaitForSeconds(waitforOnce);

        bullet.SetActive(true);
        bullet.GetComponent<Rigidbody>().AddForce(thrust, 0, 0, ForceMode.Impulse);
        bullet.transform.parent = transform_Parent;        
        
        yield return new WaitForSeconds(.3f);

        bullet.SetActive(false);
        Instantiate(bullet);
        bullet.transform.parent = transform_Child;
        bullet.transform.position = new Vector3(transform_Child.position.x, transform_Child.position.y, transform_Child.position.z);
        waitforOnce = waitforSecond;

        StartCoroutine(BulletShoots());


    }
}
