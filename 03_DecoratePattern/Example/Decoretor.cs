abstract class Decoretor : Componetnt
{
    protected Componetnt componetnt;
    public void SetComponent(Componetnt componetnt)
    {
        this.componetnt = componetnt;
    }
    public override void Operation()
    {
        if(componetnt!=null)
        {
            componetnt.Operation();
        }
    }
}