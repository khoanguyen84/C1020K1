namespace InheritDemo
{
    class Female : Human
    {
        public override string ToString()
        {
            return $"{base.ToString() }Hello from female";
        }

    }
}