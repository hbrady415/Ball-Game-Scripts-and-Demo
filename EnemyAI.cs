using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    Transform target;
    bool playerInRange;
    NavMeshAgent agent;
    private Collider myLastCol;
    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange == true)
        {
            agent.SetDestination(target.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        myLastCol = other.gameObject.GetComponent<lastCollider>().lastEntered;
        if(myLastCol is BoxCollider)
        {
            playerInRange = true;
        }
        else if(myLastCol is CapsuleCollider)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    playerInRange = false;
    //}
}
