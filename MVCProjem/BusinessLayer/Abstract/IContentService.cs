using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        void ContentAdd(Content content);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
        List<Content> GetList(string p);
        List<Content> GetListByHeadingID(int id);
        List<Content> GetListByWriter(int id);
        Content GetByID(int id);
    }
}
