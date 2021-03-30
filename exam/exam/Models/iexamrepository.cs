using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Models
{
    public interface iexamrepository<Tentity>
    {
        void add(Tentity entity);

        void update(Tentity dbentity, Tentity entity);

        void delete(Tentity entity);

        Tentity get(long id);

        IEnumerable<Tentity> getall();

    }
}
