using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecruitmentSystem
{
    internal class Candidate
    {
        public string Name { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public string Contact { get; set; }
        public string Status { get; set; }

        public Candidate(string name, string skills, string experience, string contact)
        {
            Name = name;
            Skills = skills;
            Experience = experience;
            Contact = contact;
            Status = "Applied"; // Initial status
        }

        public override string ToString()
        {
            return $"Name: {Name}, Skills: {Skills}, Experience: {Experience}, Contact: {Contact}, Status: {Status}";
        }
    }
}
   