namespace IocApp.CIL.Ribbon
{
    public interface IItem
    {
        string Name { get; set; }

        string Hint { get; set; }

        void Click();
    }
}
