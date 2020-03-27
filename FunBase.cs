abstract class FunBase: Token{

    public virtual int OperandsCount{
        get{
            return 1;
        }
    }

    public FunBase(string value)
        :base(value){
        }
    
    public abstract double Calculate(params double[] args);
}