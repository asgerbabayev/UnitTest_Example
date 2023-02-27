using JobApplicationLibrary.Models;

namespace JobApplicationLibrary;

public class ApplicationEvaluator
{
    public ApplicationResult Evaluate(JobApplication form)
    {
        if (form.Applicant.Age < 18) return ApplicationResult.AutoRejected;
        return ApplicationResult.AutoAccepted;
    }
}

public enum ApplicationResult
{
    AutoRejected,
    TransferredToHR,
    TransferredToLead,
    TransferredToCTO,
    AutoAccepted
}
