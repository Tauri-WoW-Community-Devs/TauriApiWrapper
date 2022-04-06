using System;
using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    [Flags]
    public enum GemColor
    {
        Undefined = 0,
        [Name("Meta Socket")]
        Meta = 1,
        [Name("Red Socket")]
        Red = 2,
        [Name("Yellow Socket")]
        Yellow = 4,
        [Name("Blue Socket")]
        Blue = 8,
        /// <summary>
        /// Sha-Touched
        /// </summary>
        /// 
        [Name("Sha-Touched")]
        Hydraulic = 16,
        /// <summary>
        /// Cogwheel
        /// </summary>
        [Name("Cogwheel Socket")]
        Cogwheel = 32,
    }
}
