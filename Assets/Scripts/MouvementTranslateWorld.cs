using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{       [SerializeField] private Vector3 _deplacement;
        [SerializeField] private Vector3 _rotation;

    void Update()
    {
        Vector3 mouvement = _deplacement * Time.deltaTime;
        transform.Translate(mouvement, Space.Self);

    

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
    }
}
