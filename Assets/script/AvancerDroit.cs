using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvancerDroit : MonoBehaviour
{
    public Stopavancement stopavancement;

    [SerializeField] private Transform Main;

    [SerializeField] private Transform camera;
        // Start is called before the first frame update
    void Start()
    {
        transform.position = Main.position;
        transform.localRotation = Quaternion.Euler(camera.eulerAngles.x, camera.eulerAngles.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(stopavancement.peutAvancer())
        {
            transform.position += transform.forward * Time.deltaTime * 10;
        }
       
    }
    public void Destroy()
    {
        DestroyImmediate(gameObject);
    }
}
