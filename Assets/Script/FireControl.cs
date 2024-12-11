using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public GameObject fire;
    public Rigidbody2D fireball;
    private Vector3 fireshoot;
    [SerializeField] private float firespeed;
    // Start is called before the first frame update
    void Start()
    {
        fireshoot = new Vector3(1, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        fireball.AddForce(fireshoot);
    }
}
