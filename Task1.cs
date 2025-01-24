using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    //Goal is to have user calculate the difficulty of the course they inputed
    public string courseName;
    //Input number for factors can be 1 through 10
    [Range(1f, 10f)] public float numberModules;
    [Range(1f, 10f)] public float numberMaterials;
    [Range(1f, 10f)] public float numberQuizzes;
    [Range(1f, 10f)] public float numberAssignments;
    public bool instructorExperience;
    //Instructor experience will be an if statement
    private float numberResult;

    private float numberModulePr = 0.15f;
    private float numberMaterialsPr = 0.3f;
    private float numberQuizzesPr = 0.15f;
    private float numberAssignmentsPr = 0.30f;


    void Start()
    {
        Debug.Log("Course name: " + courseName + " Challenge score: " + result() + ".");
    }

    private float instruct(bool weight)
    {
        if (weight == true)
        {
            return 1.0f;
        }
        else
        {
            return 0.0f;
        }
    }

    private float number(float weight, float height)
    {
        return weight * height;
    }

    private float result()
    {
    //Inputed number will be multiplied by the factor's decimal version of the precentage
        float numberResult = 1;
        numberResult += number(numberModules, numberModulePr);
        numberResult += number(numberMaterials, numberMaterialsPr);
        numberResult += number(numberQuizzes, numberQuizzesPr);
        numberResult += number(numberAssignments, numberAssignmentsPr);
        numberResult += instruct(instructorExperience);

        return (int)numberResult;

    }

}
