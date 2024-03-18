namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();
            var allPersonsOver30 = persons.Where(p => p.Age > 30);
            var allPersonsOver30_2 = persons.Where(IsOver30);
            var allPersonsOver30_3 = persons.Where(p => IsOver30(p));

            var allPersonsOver30_4 = persons.OuersWhere(p => p.Age > 30);
            var allPersonsOver30_5 = persons.OuersWhere(IsOver30);

            var ages = persons.Where(p => p.Name == "Pelle")
                              .Select(p => p.Age)
                              .Sum();

            var dtos = persons.Where(p => p.Name == "Nisse")
                              .Select(p => new PersonsDto
                                {
                                    Name = p.Name,
                                    NamesLength = p.Name.Length
                                });



            List<Person> res = new();
            foreach (var person in persons)
            {
                if(person.Age > 30)
                {
                    res.Add(person);
                }
            }
        }

        private static bool IsOver30(Person person)
        {
            return person.Age > 30;
        }

        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
