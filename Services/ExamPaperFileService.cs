namespace EPaperSParseR.Services;

public class ExamPaperFileService : IExamPaperFileService {
    public void Read(string? path) {
        if (path != null) {
            
        } else {
            throw new ArgumentNullException("\"path\" can't be null");
        }
    }
}