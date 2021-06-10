namespace NF.Test {
    public interface IBox {
        
    }

    public interface IBoxA : IBox
    {
        void Hello();
    }
}

public interface IBoxB : NF.Test.IBox
{
    int num { get; set; }
    int id { get; set; }
}