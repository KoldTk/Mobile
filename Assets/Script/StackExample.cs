using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    [SerializeField] private Queue<int> myQueue = new Queue<int>();
    [SerializeField] private Stack<string> myStack = new Stack<string>();
    // Start is called before the first frame update
    void Start()
    {
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);

        myStack.Push("1");
        myStack.Push("2");
        myStack.Push("3");
        myStack.Push("4");


        while (myQueue.Count > 0)
        {
            int item = myQueue.Dequeue();
            Debug.Log(item);
        }
        while (myStack.Count > 0)
        {
            string item1 = myStack.Pop();
            Debug.Log(item1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
