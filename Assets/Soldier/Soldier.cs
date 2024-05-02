using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    Animator animator;
    [SerializeField] float speed;
    [SerializeField] GameObject rightBullet;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // WALK UP ------------------------------------------------------
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("WalkUp", true);
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(upBulletPrefab, transform.position, transform.rotation);
            //}
        }
        //idle if not walking up
        else 
        {
            animator.SetBool("IdleBack", true);
            animator.SetBool("WalkDown", false);
            animator.SetBool("WalkRight", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkUp", false);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(upBulletPrefab, transform.position, transform.rotation);
            //}
        }

        // WALK DOWN ----------------------------------------------------
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("WalkDown", true);
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(downBulletPrefab, transform.position, transform.rotation);
            //}

        }
        //idle if not walking down
        else
        {
            animator.SetBool("IdleFront", true);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(downBulletPrefab, transform.position, transform.rotation);
            //}
        }

        // WALK RIGHT ------------------------------------------------------
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("WalkRight", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(rightBulletPrefab, transform.position, transform.rotation);
            //}

        }
        //idle if not walking right
        else
        {
            animator.SetBool("IdleRight", true);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(rightBulletPrefab, transform.position, transform.rotation);
            //}
        }

        // WALK LEFT ----------------------------------------------------------
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("WalkLeft", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(leftBulletPrefab, transform.position, transform.rotation);
            //}
        }
        else
        {
            animator.SetBool("IdleLeft", true);
            animator.SetBool("WalkLeft", false);

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Instantiate(leftBulletPrefab, transform.position, transform.rotation);
            //}
        }

        // INSTATIATE BULLETS
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(rightBullet, transform.position, transform.rotation);
            transform.Translate(speed * Time.deltaTime * Vector3.right);
        }
    }
}
