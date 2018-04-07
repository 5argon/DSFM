using System;

namespace DSFM
{
    /// <summary>
    /// D = Density : Amount of notes per time.
    /// S = Stress : Consecutive presses of one hand.
    /// F = Friction : Amount of movement on the screen glass. Higher number if the game requires higher speed.
    /// M = Movement : Amount of movement over the screen. DSFM will calculate a finger path automatically.
    /// </summary>
    public class DSFMEvaluation
    {
        public float Density { get; }
        public float Stress { get; }
        public float Friction { get; }
        public float Movement { get; }
    }
}