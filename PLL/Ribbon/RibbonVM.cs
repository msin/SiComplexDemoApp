using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using IocApp.CIL;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class RibbonVM : IRibbon
    {
        public virtual ObservableCollection<ICategory> Categories { get; set; }
        
        public ObservableCollection<IDesk> Desks { get; set; }

        public virtual int DesktopIndex { get; set; }

        public RibbonVM()
        {
            Messenger.Default.Register<Message>(this, OnMessage);
        }

        private void OnMessage(Message message)
        {
            switch (message.MessageType)
            {
                case MessageType.Loaded:
                    Loaded();
                    break;
            }
        }

        private void Loaded()
        {
            var category = IoC.Instance.GetInstance<ICategory>();
            category.Name = "Category 1";

            int itemNo = 1;
            int groupNo = 1;

            for (int ip = 1; ip < 4; ip++)
            {
                var page = IoC.Instance.GetInstance<IPage>();
                page.Name = "Page " + ip;

                for (int ig = 1; ig < 8; ig++)
                {
                    var group = IoC.Instance.GetInstance<IGroup>();
                    group.Name = string.Format("Group {0:00}", groupNo++);

                    for (int ii = 1; ii < 7; ii++)
                    {
                        var item = IoC.Instance.GetInstance<IItem>();
                        item.Name = "Item " + itemNo.ToString("000");
                        item.Hint = "Hint for Item " + itemNo++;

                        group.Items.Add(item);
                    }

                    page.Groups.Add(group);
                }

                category.Pages.Add(page);
            }

            //var desk = IoC.Instance.GetInstance<IPage>();
            //desk.Name = "Virtual Desktop";
            //var grp = IoC.Instance.GetInstance<IGroup>();

            //category.Pages.Add(desk);

            Categories = new ObservableCollection<ICategory> { category };

            Desks = new ObservableCollection<IDesk>();

            for (int id = 1; id < 6; id++)
            {
                var deskItem = IoC.Instance.GetInstance<IDesk>();
                deskItem.Name = "Desktop " + id;

                var desk = IoC.Instance.GetInstance<IDesk>();
                desk.Index = id;
                desk.Desc = "Virtual Destop " + id;
                Desks.Add(desk);
            }

            Desks[0].Checked = true;
        }
    }
}
