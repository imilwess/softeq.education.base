namespace TrialsSystem.UsersService.Api.Exceptions
{
    /// <summary>
    /// UserNotFondException
    /// </summary>
    public class TrialUserNotFondException : Exception
    {
        public string Id { get; }

        public TrialUserNotFondException(string id)
        {
            Id = id;
        }
    }
}
