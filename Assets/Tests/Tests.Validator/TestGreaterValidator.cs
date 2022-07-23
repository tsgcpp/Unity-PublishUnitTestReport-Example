using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Validator;

namespace Tests.EditMode
{
    public class TestGreaterValidator
    {
        [Test]
        public void ctor_Passed_CanUseZeroAsBorder()
        {
            var target = new GreaterValidator(border: 0);
            Assert.That(target.Border, Is.Zero);
        }

        [Test]
        public void ctor_Passed_CanUseZeroAsPositiveInfinity()
        {
            // Failure result example

            var target = new GreaterValidator(border: float.PositiveInfinity);
            Assert.That(target.Border, Is.EqualTo(float.PositiveInfinity));
        }

        [Test, Ignore("To Be Confirmed")]
        public void ctor_Passed_CanUseZeroAsNegativeInfinity()
        {
            var target = new GreaterValidator(border: float.NegativeInfinity);
        }

        [Test]
        public void Validate_ReturnsTrue_IfValueIsGreaterThanBorder()
        {
            var target = new GreaterValidator(border: 0);
            Assert.That(target.Validate(1), Is.True);
        }

        [Test]
        public void Validate_ReturnsFalse_IfValueIsSameAsBorder()
        {
            var target = new GreaterValidator(border: 0);
            Assert.That(target.Validate(0), Is.False);
        }

        [Test]
        public void Validate_ReturnsFalse_IfValueIsLessThanBorder()
        {
            var target = new GreaterValidator(border: 0);
            Assert.That(target.Validate(-1), Is.False);
        }
    }
}
