using OnlineChat.Bll.EfCore.Abstract.Systems;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;
using OnlineChat.Entity.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Bll.EfCore.Concrete.Systems
{

    public class PageRepository : EntityBaseRepository<Page>, IPageRepository
    {
        public PageRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
