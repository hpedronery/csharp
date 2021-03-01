namespace Vetores
{
    class Pensionato
    {
        public string Name { get; }
        public string Email { get; }
        public int Room { get; }


        public Pensionato(string name, string email, int room)
        {
            this.Name = name;
            this.Email = email;
            this.Room = room;
        }

        public override string ToString()
        {
            return Room
                + ": "
                + Name
                + ", "
                + Email;
        }

    }

}
