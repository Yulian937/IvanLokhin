using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    CubeControl player;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow }
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 5 ;
    private float walkingSpeed = 1;
    private float meleeDistance = 2;
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindObjectOfType<CubeControl>();
    }


    void Update()
    {
        {
            switch (currentlyIs)
            {



                case ZombieState.Idle:
                    if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                    {
                        currentlyIs = ZombieState.Follow;
                        zombieAnimator.SetBool("isWalking", true);
                    }

                    break;

                case ZombieState.Attack:

                    break;

                case ZombieState.Follow:

                    transform.LookAt(player.transform.position);
                    transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                    if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance);
                    currentlyIs = ZombieState.Attack;

                    break;

            }
        }
    }
}

    
        
    
      
