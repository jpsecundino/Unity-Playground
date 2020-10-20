using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TestDelegates : MonoBehaviour
{
    public delegate void MyFirstTest();
    public delegate int MySecondTest(int n);

    //we have to unsubscribe to static events but we dont need to subscribe when the event is attached to the object
    public MyFirstTest test1Func;
    private MySecondTest test2Func;
    public event EventHandler MyBuiltInEvent;

    //the advantage of unity events is that you can assign events directly from the editor
    public UnityEvent<int> myUnityEvent;
    void Start()
    {
        test1Func += Test1;
        test1Func += Test2;
        test1Func();
        myUnityEvent.AddListener(Test5);
        //myUnityEvent.AddListener(Test2);
        //myUnityEvent.Invoke();
        //Debug.Log(" Starting test2Func");
        //test2Func += Test3;
        //test2Func += Test4;
        //Debug.Log(test2Func(3));

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) test1Func();
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    // Update is called once per frame
    private void Test1()
    {
        Debug.Log("hahahaha test 1 completed");
    }
    private void Test2()
    {
        Debug.Log("hahahaha test 2 completed");
    }

    private int Test3(int n)
    {
        return n;
    }

    private int Test4(int n)
    {
        return n;
    }

    private void Test5(int n)
    {
        Debug.Log("hahahaha test 5 completed");
    }

}
