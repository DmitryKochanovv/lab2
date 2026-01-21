namespace lab2
{

    //свойства 
    class Name
    {
        public string Surname { get; set; }
        public string NameValue { get; set; }
        public string FathersName { get; set; }


        //конструктор,все свойства задействованы
        public Name(string surname, string name, string fathersName)
        {
            Surname = surname;
            NameValue = name;
            FathersName = fathersName;
        }

        public override string ToString()
        {
            string result = "";

            if (!string.IsNullOrWhiteSpace(Surname))
                result += Surname;

            if (!string.IsNullOrWhiteSpace(NameValue))
                result += (result == "" ? "" : " ") + NameValue;

            if (!string.IsNullOrWhiteSpace(FathersName))
                result += (result == "" ? "" : " ") + FathersName;

            return result;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
