using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script will set up the entry conversation between our
    main character and Friend
*/

public class Susie : MonoBehaviour
{
    /* store the path paths our character will follow */
    public Transform[] path;
    public float speed;
    public int position = 0;
    public Animator animator;
    public GameObject DialogueBox;
    private bool idle = false;

    private void Start()
    {
        /* our character will start at 0 position; dialogue has not started */
        transform.position = path[position].transform.position;
        animator = GetComponent<Animator>();
        DialogueBox.SetActive(false);
    }

    /* susie will either approach the house or idle otherwise */
    private void Update()
    {
        ApproachHouse();
    }

    private void ApproachHouse()
    {
        /* when we reach the house, our animation should face the house */
        if (position == path.Length - 1)
        {
            animator.SetBool("atHouse", true);
        }
        else if (position == path.Length)
        {
            /* play idle animation when we reach the door; trigger dialogue */
            animator.SetBool("atDoor", true);
            idle = true;
            DialogueBox.SetActive(true);
        }

        /* check if our character has reached the last way point */
        if (position <= path.Length - 1)
        {
            transform.position = 
                Vector3.MoveTowards(transform.position, 
                                    path[position].transform.position,
                                    speed * Time.deltaTime);

            /* send the character to the next way point if the
               current one has been reached */
            if (transform.position == path[position].transform.position)
            {
                position += 1;
            }
        }
    }
}
