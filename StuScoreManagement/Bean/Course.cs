using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScoreManagement
{
    public class Course
    {
        private string code;
        private string name;
        private int credit;
        private decimal score;
        private int chosenCount;
        public Course() { }
        public string Code
        {
            set { this.code = value; }
            get { return this.code; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public int Credit
        {
            set { this.credit = value; }
            get { return this.credit; }
        }
        public decimal Score
        {
            set { this.score = value; }
            get { return this.score; }
        }
        public int ChosenCount
        {
            set { this.chosenCount = value; }
            get { return this.chosenCount; }
        }
    }
}
