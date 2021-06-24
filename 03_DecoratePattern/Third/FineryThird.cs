using System;
class FineryThird : PersonThird
{
    protected PersonThird component;
    //打扮
    public void Decorate(PersonThird component)
    {
        this.component = component;
    }
    public override void Show()
    {
        if(component!=null)
        {
            component.Show();
        }
    }
}