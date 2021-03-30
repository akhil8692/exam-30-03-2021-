using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Models
{
    public class examrepository : iexamrepository<exammodel>
    {
        readonly examdbcontext _examdbcontext;
        
        public examrepository(examdbcontext context)
        {
            _examdbcontext = context;
        }

        public void add(exammodel entity)
        {
            _examdbcontext.examdb.Add(entity);
            _examdbcontext.SaveChanges();
            //throw new NotImplementedException();
        }

        public void delete(exammodel entity)
        {
            _examdbcontext.examdb.Remove(entity);
            _examdbcontext.SaveChanges();
            //throw new NotImplementedException();
        }

        public exammodel get(long id)
        {
            return _examdbcontext.examdb.FirstOrDefault(e => e.id == id);
            //throw new NotImplementedException();
        }

        public IEnumerable<exammodel> getall()
        {
            return _examdbcontext.examdb.ToList();
            //throw new NotImplementedException();
        }

        public void update(exammodel dbentity, exammodel entity)
        {
            dbentity.description = entity.description;
            dbentity.isdone = entity.isdone;
            _examdbcontext.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
