using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class Student1
    {
        public void StudentList()
        {

            // initialize variables - graded assignments
            int examAssignments = 5;
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;
                int gradedAssignments = 0;
                
                foreach (int score in studentScores)
                {
                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // add the exam score to the sum
                        sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

        }
    }
}
