using JobApplicationLibrary;
using JobApplicationLibrary.Models;

namespace JobApplicationUnitTest;

public class JobApplicationTest
{


    [Test]
    public void ApplicationEvalutor_WithUnderAge_UnderCondition()
    {
        // Arrange
        ApplicationEvaluator evaluator = new ApplicationEvaluator();
        JobApplication form = new JobApplication()
        {
            Applicant = new()
            {
                Age = 18
            }
        };
        // Act
        var result = evaluator.Evaluate(form);

        // Assert
        Assert.That(result, Is.EqualTo(ApplicationResult.AutoAccepted));
    }
}
