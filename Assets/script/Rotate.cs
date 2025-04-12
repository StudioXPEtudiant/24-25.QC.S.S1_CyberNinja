using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Stopavancement stopavancement;
    [SerializeField] private float rotate;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(stopavancement.peutAvancer())
        {
            rotate += 720 * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(-90, rotate, 0);
        }
       
    }
}
