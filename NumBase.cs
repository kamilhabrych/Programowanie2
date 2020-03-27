abstract class NumBase: Token{

        public abstract double Value{
            get;
        }

        public NumBase(string value)
            :base(value){
            }
}