using System;
using EnumI18N.Reference;

namespace EnumI18N.Models
{
    public class Project
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public ProjectState State { get; set; }

        public Project(Guid id, string description, string state)
        {
            // Sample constructor to populate from database values.
            ID = id;
            Description = description;
            State = LocalizedEnums.ProjectStates.ForDBValue(state);
        }
    }
}
