using System.Collections.Generic;

namespace FifaCareerManager.Management.Mappings
{
    public static class PositionMapping
    {
        public enum Position
        {
            /// <summary>
            /// Goalkeeper
            /// </summary>
            GK,
            /// <summary>
            /// Right Back
            /// </summary>
            RB,
            /// <summary>
            /// Right Wing Back
            /// </summary>
            RWB,
            /// <summary>
            /// Center Back
            /// </summary>
            CB,
            /// <summary>
            /// Left Wing Back
            /// </summary>
            LWB,
            /// <summary>
            /// Left Back
            /// </summary>
            LB,
            /// <summary>
            /// Center Defensive Midfielder
            /// </summary>
            CDM,
            /// <summary>
            /// Right Midfielder
            /// </summary>
            RM,
            /// <summary>
            /// Center Midfielder
            /// </summary>
            CM,
            /// <summary>
            /// Left Midfielder
            /// </summary>
            LM,
            /// <summary>
            /// Center Attacking Midfielder
            /// </summary>
            CAM,
            /// <summary>
            /// Right Wing
            /// </summary>
            RW,
            /// <summary>
            /// Centre Forward
            /// </summary>
            CF,
            /// <summary>
            /// Left Wing
            /// </summary>
            LW,
            /// <summary>
            /// Right Forward
            /// </summary>
            RF,
            /// <summary>
            /// Striker
            /// </summary>
            ST,
            /// <summary>
            /// Left Forward
            /// </summary>
            LF
        }

        public static readonly Dictionary<string, Position> PositionMap = new Dictionary<string, Position>
        {
            {"GK", Position.GK },
            {"RB", Position.RB },
            {"RWB", Position.RWB },
            {"CB", Position.CB },
            {"LWB", Position.LWB },
            {"LB", Position.LB },
            {"CDM", Position.CDM },
            {"RM", Position.RM },
            {"CM", Position.CM },
            {"LM", Position.LM },
            {"CAM", Position.CAM },
            {"RW", Position.RW },
            {"CF", Position.CF },
            {"LW", Position.LW },
            {"RF", Position.RF },
            {"ST", Position.ST },
            {"LF", Position.LF }

        };
    }
}
