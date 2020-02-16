using System.Collections.Generic;
using System.Linq;
using EnumI18N.Reference;

namespace EnumI18N
{
    public static class LocalizedEnums
    {
        public const string DISPLAY_MEMBER = "ValueForUI";
        public const string VALUE_MEMBER = "ValueForDB";

        private static readonly List<ProjectState> _projectStates = new List<ProjectState>();

        private const string PROJECT_STATE_OPEN = "Open";
        private const string PROJECT_STATE_ON_HOLD = "OnHold";
        private const string PROJECT_STATE_CLOSED = "Closed";

        static LocalizedEnums()
        {
            _projectStates.Add(new ProjectState(PROJECT_STATE_OPEN));
            _projectStates.Add(new ProjectState(PROJECT_STATE_ON_HOLD));
            _projectStates.Add(new ProjectState(PROJECT_STATE_CLOSED));
        }

        public static class ProjectStates
        {
            public static ProjectState Open { get { return _projectStates.Single(x => x.ValueForDB == PROJECT_STATE_OPEN); } }
            public static ProjectState OnHold { get { return _projectStates.Single(x => x.ValueForDB == PROJECT_STATE_ON_HOLD); } }
            public static ProjectState Closed { get { return _projectStates.Single(x => x.ValueForDB == PROJECT_STATE_CLOSED); } }

            public static List<ProjectState> ToList()
            {
                return _projectStates;
            }

            public static ProjectState ForDBValue(string valueFromDB)
            {
                return _projectStates.Single(x => x.ValueForDB == valueFromDB);
            }
        }
    }
}
