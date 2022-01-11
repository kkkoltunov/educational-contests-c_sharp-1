using System;
using System.Collections.Generic;

public class SchoolManager
{
    public static void UniteSchools(List<School> schools, List<string> schoolNumbers)
    {
        string firstSchoolNumb = "";
        bool flag = false;
        int counterUnion = 1;

        for (int i = 0; i < schools.Count; i++)
        {
            if (schoolNumbers.Contains(schools[i].SchoolNumber))
            {   
                if (!flag)
                {
                    firstSchoolNumb = schools[i].SchoolNumber;
                    flag = true;
                }

                schools[i].SchoolNumber = $"{firstSchoolNumb}-{counterUnion++}";

                for (int j = 0; i < schools[i].Pupils.Count; j++)
                {
                    
                    schools[i].Pupils[j].SchoolNumber = schools[i].SchoolNumber;
                }

                schools[i].WasUnited = true;
            }
        }
    }

    public static void TransferPupil(List<Pupil> pupils, List<School> schools, int pupilId, string newSchoolNumber)
    {
        Pupil pupil = new Pupil();
        
        for (int i = 0; i < schools.Count; i++)
        {
            for (int j = 0; j < schools[i].Pupils.Count; j++)
            {
                if (schools[i].Pupils[j].Id == pupilId)
                {
                    pupil = schools[i].Pupils[j];
                    schools[i].Pupils.Remove(schools[i].Pupils[j]);
                }
            }
        }

        pupil.SchoolNumber = newSchoolNumber;

        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].SchoolNumber == newSchoolNumber)
                schools[i].Pupils.Add(pupil);
        }
    }

    public static void CloseSchool(List<School> schools, string schoolNumber, string newSchoolNumber)
    {
        School school = new School();

        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].SchoolNumber == newSchoolNumber)
            {
                school = schools[i];
                break;
            }
        }

        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].SchoolNumber == newSchoolNumber)
            {
                
                break;
            }
        }
    }
}