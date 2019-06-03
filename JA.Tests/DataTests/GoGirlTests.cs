using System;
using System.Collections.Generic;
using System.Text;
using JA.FE.Controllers;
using NUnit;
using NUnit.Framework;
using FluentAssertions;
using FluentAssertions.AspNetCore.Mvc;

namespace JA.Tests.DataTests
{
    class GoGirlTests
    {

        [Test]
        public void Index_Action_Returns_View()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            result.Should().BeViewResult();
        }
    }
}
