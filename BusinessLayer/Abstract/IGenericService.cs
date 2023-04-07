﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        List<T> TGetListByFilter(Expression<Func<T, bool>> filter);
        List<T> TGetLastN(int N);
        T TGetById(int id);
    }
}
