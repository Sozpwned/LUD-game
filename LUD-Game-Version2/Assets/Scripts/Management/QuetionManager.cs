using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetionManager : MonoBehaviour
{
    public QuestionLoader qLoader;
    // Start is called before the first frame update
    void Awake()
    {
        qLoader = new QuestionLoader();
        foreach(Question q in qLoader.questions) {
            Debug.Log(string.Format("Title: {0}, Text: {1}, player count: {2}", 
                                             q.title,   q.text, q.playerCount));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
