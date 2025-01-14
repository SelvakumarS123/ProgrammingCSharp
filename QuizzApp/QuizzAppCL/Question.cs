namespace QuizzAppCL
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }

        public int AnsrIndex { get; set; }

        public Question(string questionText, string[] options, int ansrIndex)
        {
            QuestionText = questionText;
            Options = options;
            AnsrIndex = ansrIndex;
        }

        public bool IsAnsrIndex(int choice)
        {
            return AnsrIndex == choice;
        }
    }
}
