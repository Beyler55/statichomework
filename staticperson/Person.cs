namespace staticperson
{
    class Person
    {
        private static int _age;
        public int Age
        {
            get
            {
                return ++_age;
            }
            set
            {
            }
        }
    }
}
