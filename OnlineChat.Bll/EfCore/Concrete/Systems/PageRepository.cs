using OnlineChat.Bll.EfCore.Abstract.Systems;
using OnlineChat.Core.Entities.Systems;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;

namespace OnlineChat.Bll.EfCore.Concrete.Systems
{

    public class PageRepository : EntityBaseRepository<Page>, IPageRepository
    {
        public PageRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
