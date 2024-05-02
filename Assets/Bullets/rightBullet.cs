using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject rightBullet;

    //Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(rightBullet, transform.position, transform.rotation);
        }
        transform.Translate(speed * Time.deltaTime * Vector3.right);
    }
}
