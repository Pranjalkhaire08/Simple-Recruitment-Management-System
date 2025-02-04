
using System;

namespace SimpleRecruitmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RecruitmentSystem system = new RecruitmentSystem();

            while (true) // Main program loop
            {
                Console.WriteLine("\nRecruitment System Menu:");
                Console.WriteLine("1. Add Candidate");
                Console.WriteLine("2. Update Candidate Status");
                Console.WriteLine("3. List Candidates");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCandidate(system);
                        break;
                    case "2":
                        UpdateCandidateStatus(system);
                        break;
                    case "3":
                        system.ListCandidates();
                        break;
                    case "4":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Helper functions to get candidate details from the user
        static void AddCandidate(RecruitmentSystem system)
        {
            Console.Write("Enter candidate name: ");
            string name = Console.ReadLine();
            Console.Write("Enter skills: ");
            string skills = Console.ReadLine();
            Console.Write("Enter experience: ");
            string experience = Console.ReadLine();
            Console.Write("Enter contact information: ");
            string contact = Console.ReadLine();

            Candidate candidate = new Candidate(name, skills, experience, contact);
            system.AddCandidate(candidate);
        }

        static void UpdateCandidateStatus(RecruitmentSystem system)
        {
            Console.Write("Enter candidate name to update: ");
            string name = Console.ReadLine();
            Console.Write("Enter new status (e.g., Applied, Interviewing, Hired, Rejected): ");
            string status = Console.ReadLine();
            system.UpdateCandidateStatus(name, status);
        }
    }
}