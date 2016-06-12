using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewIT_Backend.Models;

namespace Unit_Test
{
    [TestClass]
    class ModelTest
    {
        public void UserModelTest()
        {
            // Arrange
            var model = new UserModel();

            // Assert
            Assert.
        }



        private static IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }
    }
}
