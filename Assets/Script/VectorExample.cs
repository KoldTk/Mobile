using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    [SerializeField] private Vector3 vector1;
    [SerializeField] private Vector3 vector2;
    [SerializeField] private Vector3 addition;
    [SerializeField] private Vector3 subtraction;
    [SerializeField] private Vector3 multiplication;
    [SerializeField] private Vector3 division;
    [SerializeField] private float dotProduct;
    [SerializeField] private Vector3 crossProduct;
    [SerializeField] private float magnitude;
    [SerializeField] private Vector3 normalized;
    void Start()
    {
        vector1 = new Vector3(1, 2, 0);
        vector2 = new Vector3(5, 10, 0);

        addition = vector1 + vector2;
        subtraction = vector1 - vector2;
        multiplication = vector1 * 4;
        division = vector1 / 2;

        Debug.Log($"Addition: {addition} ");
        Debug.Log($"Subtraction: {subtraction}");
        Debug.Log($"Multiplication: {multiplication}");
        Debug.Log($"Division: {division}");

        dotProduct = Vector3.Dot(vector1, vector2);
        crossProduct = Vector3.Cross(vector1, vector2);
        magnitude = vector1.magnitude;
        normalized = vector1.normalized;

        Debug.Log($"Dot Product: {dotProduct}");
        Debug.Log($"Cross Product: {crossProduct}");
        Debug.Log($"Magnitude: {magnitude}");
        Debug.Log($"Normalized: {normalized}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
