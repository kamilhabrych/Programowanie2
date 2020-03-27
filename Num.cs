class Num: NumBase{

    public override double Value{
        get{
            return double.Parse(Entry);
        }
    }

    public Num(double value)
        :this(value.ToString()){
        }

    public Num(string value)
        :base(value){
        }
}