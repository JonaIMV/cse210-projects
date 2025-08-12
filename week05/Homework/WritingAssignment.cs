namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic) // Llama al constructor base
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return $"{_title} by {StudentName}";
        }
    }
}
