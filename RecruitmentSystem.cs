using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecruitmentSystem
{
    internal class RecruitmentSystem
    {
            private List<Candidate> candidates;

            public RecruitmentSystem()
            {
                candidates = new List<Candidate>();
            }

            public void AddCandidate(Candidate candidate)
            {
                candidates.Add(candidate);
                Console.WriteLine($"Candidate {candidate.Name} added successfully.");
            }

            public void UpdateCandidateStatus(string name, string newStatus)
            {
                Candidate candidate = FindCandidate(name);
                if (candidate != null)
                {
                    candidate.Status = newStatus;
                    Console.WriteLine($"Status of {candidate.Name} updated to {newStatus}.");
                }
                else
                {
                    Console.WriteLine($"Candidate {name} not found.");
                }
            }

            public void ListCandidates()
            {
                if (candidates.Count == 0)
                {
                    Console.WriteLine("No candidates found.");
                }
                else
                {
                    Console.WriteLine("List of Candidates:");
                    foreach (Candidate candidate in candidates)
                    {
                        Console.WriteLine(candidate);
                    }
                }
            }

            private Candidate FindCandidate(string name)
            {
                // Using LINQ for more concise searching
                return candidates.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
        }
    }