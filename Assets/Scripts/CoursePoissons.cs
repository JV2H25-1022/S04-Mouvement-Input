using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoursePoissons : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 vitesse;
    void Start()
    {
        vitesse.z = Random.Range(1f, 2f); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesse * Time.deltaTime, Space.Self);
        if(transform.position.x > 5f){
            Debug.Log(gameObject.name);
        }

        
    }
}
