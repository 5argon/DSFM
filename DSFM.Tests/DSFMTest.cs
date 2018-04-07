using System;
using Xunit;
using DSFM;
using FluentAssertions;

namespace DSFM.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyDSFM()
        {
            DSFM dsfm = new DSFM();
            DSFMEvaluation evaluation = dsfm.Evaluate();
            evaluation.Density.Should().Be(0);
            evaluation.Stress.Should().Be(0);
            evaluation.Friction.Should().Be(0);
            evaluation.Movement.Should().Be(0);
        }

        [Fact]
        public void NonEmptyDSFM()
        {
            DSFM dsfm = new DSFM();
            dsfm.AddNote(time: 1, position: new DSFMPosition(10, 20), fingerHint: DSFMFingerHint.Any);

            DSFMEvaluation evaluation = dsfm.Evaluate();
            evaluation.Density.Should().NotBe(0, "We have added some notes");
        }
    }
}
