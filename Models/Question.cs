namespace EPaperSParseR.Models;

public class Question {
    // 附加在题干前的信息，比如哪一年哪个地方
    public string? ExtraTitle { get; set; }
    public Subject Subject { get; set; }
    // TODO: set correct DataType for content
    public string? Content { get; set; }
    public Answer? Answer { get; set; }
}