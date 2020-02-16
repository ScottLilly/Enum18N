namespace EnumI18N.Reference
{
    public class ProjectState : LocalizableEnumValue
    {
        protected internal ProjectState(string databaseValue) : base(databaseValue)
        {
        }

        public override bool Equals(System.Object obj)
        {
            return Equals(obj as ProjectState);
        }

        public bool Equals(ProjectState projectState)
        {
            if(projectState == null)
            {
                return false;
            }

            return (ValueForDB == projectState.ValueForDB);
        }

        public override int GetHashCode()
        {
            return (_databaseValue != null ? _databaseValue.GetHashCode() : 0);
        }

        public static bool operator ==(ProjectState a, ProjectState b)
        {
            // If both are null, or both are same instance, return true.
            if(ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if(((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.ValueForDB == b.ValueForDB;
        }

        public static bool operator !=(ProjectState a, ProjectState b)
        {
            return !(a == b);
        }
    }
}
