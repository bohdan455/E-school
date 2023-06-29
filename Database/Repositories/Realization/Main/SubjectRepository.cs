using Database.Entities;
using Database.Repositories.Interfaces;
using Database.Repositories.Realization.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Realization.Main
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(SchoolDataContext context) : base(context)
        {
        }
    }
}
