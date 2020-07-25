using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class QuestionLoader 
{
         private QuestionList questionList = new QuestionList();
         public List<Question> questions = new List<Question>();
    public QuestionLoader() {
        LoadQuestions("TestQuestions");
        LoadQuestions("MoreQuestions");
    }
    private void LoadQuestions(string fileName) {
        TextAsset qAsset = Resources.Load(fileName) as TextAsset;

        if (qAsset!=null) {
            questionList = JsonUtility.FromJson<QuestionList>(qAsset.text);
            Debug.Log("Asset: "+fileName+", should be loaded");
            foreach (Question q in questionList.Question) {
                questions.Add(q);
            }
        } else {
            Debug.Log("Asset is null");
        }
    }
}
