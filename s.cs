using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class s : MonoBehaviour
{
    public GameObject Obj;
    public Animator anime;
    bool Stay;
    // Use this for initialization
    void Start()
    {
    } // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Stay)
        {
            Obj.GetComponent<Animator>().SetBool("Enter", true);
            anime = GetComponent<Animator>();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Stay = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Stay = false;
        }
    }
    void OnGUI()
    {
        if (Stay)
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 150, 300, 25), "'E'" );
   }
}