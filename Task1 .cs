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
    public bool instructorExperience = true;
    //Instructor experience will an if statement
    private float numberResult = 1.0f;

    private float numberModulePr = 0.15f;
    private float numberMaterialsPr = 0.3f;
    private float numberQuizzesPr = 0.15f;
    private float numberAssignmentsPr = 0.30f;
    private float instructorExperiencePr = 0.1f;

    //Inputed number will be multiplied by the factor's decimal version of the precentage
    void Start()
     {
        Debug.Log(result());
        Debug.Log("Course name: " + courseName + " Challenge score: " + numberResult + ".");

    }
  private float instr(bool weight, float height) 
    {
        if (weight == true) return height; else {return 0;}
    }

    private float ahhhh(float weight, float height)
    {
        return weight * height; 
    }
 
   private float result()
    {
        int returnVariable;
        returnVariable = (int)(numberResult += ((ahhhh(numberModules, numberModulePr)) + (ahhhh(numberMaterials, numberMaterialsPr)) + (ahhhh(numberQuizzes, numberQuizzesPr)) + (ahhhh(numberAssignments, numberAssignmentsPr)) + (instr(instructorExperience, instructorExperiencePr))));
        return returnVariable;
    }
    
    }
