namespace JobApplicationLibrary.Models;

public class JobApplication
{
    public Applicant Applicant { get; set; } = null!;
    public int YearsOfExperience { get; set; }
    public List<string> TechStackList { get; set; }
    public JobApplication() => TechStackList = new List<string>();
}
