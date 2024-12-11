using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListEx : MonoBehaviour
{
    [SerializeField] private List<int> myList;
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Bull", 2);
        myDictionary.Add("Cow", 3);
        myDictionary.Add("Dragon", 4);

        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(1);
        myArrayList.Add("Hello");
        myArrayList.Add(3.14);
        myArrayList.Add("World!");
        myArrayList.Remove(3);
        myArrayList.Contains(1);
        

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(2);
        myList.Add(3);
        myList.Add(67);
        myList.Add(7);
        myList.Remove(3);
        myList.Contains(1);
        myList.Sort();
        foreach (int item in myList)
        {
            Debug.Log(item);
        }

        foreach (var item in myArrayList)
        {
            Debug.Log(item);
        }

        foreach (KeyValuePair<string, int> item in myDictionary)
        {
            Debug.Log(item.Key + ": " + item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
