namespace ReadWriteProperties
{
    public class ReadWrite
    {
        private string name = "Default Name";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}