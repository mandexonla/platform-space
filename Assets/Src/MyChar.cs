using UnityEngine;

public class MyChar : MonoBehaviour
{
    string myName = "empty";
    int myAge = 0;
    float myHeight = 0.0f;

    string GetMyName()
    {
        string newName = "Mandela";
        //Debug.Log("GetMyName");
        return newName;
    }

    void Start()
    {
        Debug.Log("Hello World");
        this.myName = this.GetMyName();
        Debug.Log(this.myName);
    }

    private void Update()
    {
        Debug.Log("Update called");
        //this.GetMyName();
    }
}
