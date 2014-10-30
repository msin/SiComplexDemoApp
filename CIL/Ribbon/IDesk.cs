namespace IocApp.CIL.Ribbon
{
    public interface IDesk
    {
        int Index { get; set; }

        bool Checked { get; set; }

        string Name { get; set; }

        string Desc{ get; set; }
    }
}
