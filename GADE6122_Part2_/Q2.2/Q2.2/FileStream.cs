namespace Task_1
{
    internal class FileStream
    {
        private string v;
        private object create;
        private object write;
        private object none;

        public FileStream(string v, object create, object write, object none)
        {
            this.v = v;
            this.create = create;
            this.write = write;
            this.none = none;
        }
    }
}