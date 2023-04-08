namespace EPaperSParseR.Models;

public class ExamPaper {
    public string? Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Question>? Questions { get; set; }
}