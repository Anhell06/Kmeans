namespace myApp
{
    public class DataItem<T>
    {

        private T[] _input = null;
        private T[] _output = null;

        public DataItem(T[] input, T[] output = null)
        {
            _input = input;
            _output = output;
        }

        public T[] Input
        {
            get { return _input; }
        }

        public T[] Output
        {
            get { return _output; }
            set { _output = value; }
        }

    }
}