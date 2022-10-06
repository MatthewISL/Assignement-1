namespace FootballPlayer
{
    //dd
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }



        public void ValidateId()
        {

            if (Id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Id));
            }
        }
        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(Name));
            }
        }
        public void ValidateAge()
        {
            if (Age < 18)
            {
                throw new ArgumentOutOfRangeException(nameof(Age));
            }
        }
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
            }
        }

        public void Validate()
        {
            ValidateId();
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }
    }
}