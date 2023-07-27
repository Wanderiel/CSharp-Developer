namespace _10_DeepOOP_Part01.Databases
{
    public readonly struct Log
    {
        public Log(int idClient, DateTime dateTime, string fieldName, string typeOfChanges, string userName)
        {
            IdClient = idClient;
            DateTime = dateTime;
            FieldName = fieldName;
            TypeOfChanges = typeOfChanges;
            UserName = userName;
        }

        public int IdClient { get; }
        public DateTime DateTime { get; }
        public string FieldName { get; }
        public string TypeOfChanges { get; }
        public string UserName { get; }
        public string Full
            => $"{DateTime} - {FieldName} - {TypeOfChanges} - {UserName}";
    }
}
