using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopavancement : MonoBehaviour
{
    [SerializeField] private bool PeutAvancer = true;

    public GameObject fissur;

    [SerializeField] private Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 20f, Color.black);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 20f))
        {
            destination = hit.transform.localPosition;

            if(transform.localPosition == destination)
            {
                Debug.Log("touché");
                PeutAvancer = false;
                fissur.SetActive(true);
            }
        }
    }

    public bool peutAvancer()
    {
        return PeutAvancer;
    }

 
}
