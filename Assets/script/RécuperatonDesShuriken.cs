using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RécuperatonDesShuriken : MonoBehaviour
{

    [Header("Script")]

    [SerializeField] private AvancerDroit av;

    [SerializeField] private StokageEtTireDesShuriken stokage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(2))
        {
            Debug.DrawRay(transform.position, transform.forward * 10, Color.blue);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                if(hit.transform.CompareTag("SHURIKEN"))
                {
                    // Debug.Log("shuriken toucher");
                    stokage.ajout();
                    hit.transform.GetComponent<AvancerDroit>().Destroy();
                }
            }
        }
    }
}
