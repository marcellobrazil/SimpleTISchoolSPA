using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Repositories
{
    public interface IRepository { }

    public interface IRepository<T>: IRepository
    {
        IEnumerable<T> List();
    }
}
