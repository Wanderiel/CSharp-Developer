namespace _10_DeepOOP_Part01.Databases
{

    public readonly struct Log
    {
        public Log(DateTime dateTime, string fieldName, string typeOfChanges, string user)
        {
            DateTime = dateTime;
            FieldName = fieldName;
            TypeOfChanges = typeOfChanges;
            User = user;
        }

        public DateTime DateTime { get; }
        public string FieldName { get; }
        public string TypeOfChanges { get; }
        public string User { get; }
        public string Data
            => $"[{DateTime} - {FieldName} - {TypeOfChanges} - {User}]";
    }
}
