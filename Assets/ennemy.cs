using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ennemy : MonoBehaviour
{
    public List<Health1> Hl;
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private Transform player;

    [SerializeField] private bool deplacement;

    [SerializeField] private float distance;

    [SerializeField] private float MinDistanceAttack; 

    [SerializeField] private Animator an;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deplacement == true)
        {
            agent.SetDestination(player.position);
        }

        if (Vector3.Distance(player.position, transform.position) < distance)
        {
            deplacement = true;
            an.SetBool("Déplacement", true);
        }
        else
        {
            deplacement = false;
            an.SetBool("Déplacement", false);
        }

        if(Vector3.Distance(player.position, transform.position) < MinDistanceAttack)
        {
            deplacement = false;
            an.SetBool("Déplacement", false);
            an.SetBool("Attack", true);
        }
        else
        {
            an.SetBool("Attack", false);
        }
    
    }


    public void onDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, MinDistanceAttack);
    }

    public void Attack()
    {
        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.forward * 2, Color.black);

        if(Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.transform.CompareTag("Player"))
            {
                hit.transform.GetComponent<Health1>().HealthDecrease();
            }
        }

    }
}
