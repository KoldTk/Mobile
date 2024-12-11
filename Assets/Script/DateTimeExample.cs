using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DateTimeExample : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime specificDate;
    [SerializeField] private DateTime newtimespan;
    [SerializeField] private TimeSpan specificTimespan;
    [SerializeField] private double totaltime;
    [SerializeField] private DateTime newDate;
    // Start is called before the first frame update
    void Start()
    {
        now = DateTime.Now;
        specificDate = new DateTime(2024, 10, 22);
        Debug.Log($"Current Date and Time: {now} ");
        Debug.Log($"Specific Date: {specificDate}");

        TimeSpan duration = new TimeSpan(9, 30, 0);
        Debug.Log($"TimeSpan Duration: {duration} ");

        newtimespan = specificDate.AddDays(5);
        Debug.Log($"TimeSpan Duration: {newtimespan}");
        newtimespan = newtimespan.AddHours(5);
        Debug.Log($"TimeSpan Duration: {newtimespan}");
        specificTimespan = TimeSpan.FromDays(10);
        Debug.Log($"TimeSpan Duration: {specificTimespan}");
        
        totaltime = duration.TotalMinutes;
        Debug.Log($"Total Minute: {totaltime}");

        newDate = now.AddDays(2);


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
