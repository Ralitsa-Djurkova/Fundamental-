using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] cmdArgs = input.Split(":").ToArray();
                string firstCommand = cmdArgs[0];
                string lessonTitle = cmdArgs[1];


                if (firstCommand == "Add")
                {
                    if (!data.Contains(lessonTitle))
                    {
                        data.Add(lessonTitle);

                    }
                   
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (!data.Contains(lessonTitle))
                    {
                        data.Insert(index, lessonTitle);

                    }
                }
                else if (firstCommand == "Remove")
                {

                    data.Remove(lessonTitle);
                }
                else if (firstCommand == "Swap")
                {
                    string secondCommand = cmdArgs[2];

                    int indexOfFirstLeeson = data.IndexOf(lessonTitle);
                    int indexOfSecondLesson = data.IndexOf(secondCommand);

                    if (indexOfFirstLeeson != -1 && indexOfSecondLesson != -1)
                    {
                        data[indexOfFirstLeeson] = secondCommand;
                        data[indexOfSecondLesson] = lessonTitle;

                        string firstLessonExercise = $"{lessonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLeeson + 1;

                        if (indexOfFirstLeeson < data.Count &&
                            data[indexOfFirstExercise] == firstLessonExercise)
                        {
                            data.RemoveAt(indexOfFirstExercise);
                            indexOfFirstExercise = data.IndexOf(lessonTitle);
                            data.Insert(indexOfFirstExercise, firstLessonExercise);
                        }

                        string secondLessonExercise = $"{secondCommand}-Exercise";
                        int indexOfSecondExercise = indexOfSecondLesson + 1;

                        if (indexOfSecondExercise < data.Count && data[indexOfSecondExercise] == secondLessonExercise)
                        {
                            data.RemoveAt(indexOfSecondLesson + 1);
                            indexOfSecondLesson = data.IndexOf(secondCommand);
                            data.Insert(indexOfSecondLesson + 1, secondLessonExercise);
                        }
                    }

                }
                else if (firstCommand == "Exercise")
                {
                    int index = data.IndexOf(lessonTitle);
                    string exercise = $"{lessonTitle}-Exercise";

                    bool isThereAreLesson = data.Contains(lessonTitle);
                    bool isThereAreExercise = data.Contains(exercise);

                    if (isThereAreLesson && !isThereAreExercise)
                    {
                        data.Insert(index + 1, exercise);
                    }
                    else if (!isThereAreLesson)
                    {
                        data.Add(lessonTitle);
                        data.Add(exercise);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{data[i]}");
            }
        }

    }
}
