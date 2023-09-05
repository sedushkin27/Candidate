namespace HomeworkCandidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> candidates = new List<Candidate>();

            Candidate candidate1 = new Candidate("1", 0, new DateTime(2005, 1, 1));
            Candidate candidate2 = new Candidate("2", 5, new DateTime(1990, 1, 1));

            candidates.Add(candidate1);
            candidates.Add(candidate2);

            MailSender mailSender = new MailSender();

            foreach (Candidate candidate in candidates)
            {
                mailSender.SendMail(candidate);
            }
        }
    }
}