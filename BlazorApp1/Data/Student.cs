namespace BlazorApp1.Data
{
    public class Student
    {
        //int i = Random.Shared.Next(0, 10);
        private int id;
        private string name;
        private string surname;
        private string otch;
        private string image;
        private string group;
        private DateOnly birthday;
        public Student(int id1, string surnam, string nam, string otc, string imag, string grou, DateOnly birtday)
            {
                ID = id1;
                Name = nam;
                Surname = surnam;
                Otch = otc;
                Image = imag;
                Group = grou;
                Birthday = birtday;
            }
        public int ID
        { get { return id; } set {  id = value; } }
        public string Name
        { get { return name; } set {  name = value; } }
        public string Surname
        { get { return surname; } set { surname = value; } }
        public string Otch
        { get { return otch; } set {  otch = value; } }
        public string Image
        { get { return image; } set {  image = value; } }
        public string Group
        { get { return group; } set {  group = value; } }
        public DateOnly Birthday
        { get { return birthday; } set { birthday = value; } }
    }
}
