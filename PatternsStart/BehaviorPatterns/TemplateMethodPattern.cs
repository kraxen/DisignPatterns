using BehaviorPatterns.Template_Method;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class TemplateMethodPattern : IPattern
    {
        public void Start()
        {

            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();

        }
    }
}
