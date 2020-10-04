using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternProj.Data
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Update();
        T Delete();

    }
}
