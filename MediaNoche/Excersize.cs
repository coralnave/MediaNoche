//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaNoche
{
    using System;
    using System.Collections.Generic;
    
    public partial class Excersize
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Video { get; set; }
        public Nullable<int> EveningLesson_ID { get; set; }
        public Nullable<int> Lesson_ID { get; set; }
    
        public virtual EveningLesson EveningLesson { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
