namespace TeachAssist.Models
{
    public class Student
    {
        private string id;
        private string name;
        private string homecity;
        private string telephone;
        private int state;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Homecity { get => homecity; set => homecity = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int State { get => state; set => state = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id}, {nameof(Name)}={Name}, {nameof(Homecity)}={Homecity}, {nameof(Telephone)}={Telephone}, {nameof(State)}={State.ToString()}}}";
        }
    }
}
