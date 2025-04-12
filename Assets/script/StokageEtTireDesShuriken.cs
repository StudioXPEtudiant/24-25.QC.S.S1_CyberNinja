using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StokageEtTireDesShuriken : MonoBehaviour
{
    [Header("ObjectShuriken")]

    [SerializeField] private GameObject shuriken;

    [Header("NShuriken")]

    [SerializeField] private int NombreMaxShuriken;

    [SerializeField] private int NombreShuriken;

    [SerializeField] private int NombreMinShuriken;

    [Header("BOOL")]

    [SerializeField] private bool peutTiré;

    [Header("Touch")]

    [SerializeField] private KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        NombreShuriken = NombreMaxShuriken;
    }

    // Update is called once per frame
    void Update()
    {
        if(NombreShuriken >= 1)
        {
            peutTiré = true;
        }
        if(NombreShuriken <= 0)
        {
            peutTiré = false;
        }
        if(peutTiré == true)
        {
            if (Input.GetKeyDown(keyCode))
            {
                GameObject clone = Instantiate(shuriken);
             //clone.transform.parent = null;
                clone.SetActive(true);
                NombreShuriken += -1;
            }
        }
      
    }

    public void ajout()
    {
        NombreShuriken += 1;
    }
}
