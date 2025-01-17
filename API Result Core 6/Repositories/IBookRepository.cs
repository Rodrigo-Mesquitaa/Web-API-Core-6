﻿using System.Collections.Generic;
using System.Threading.Tasks;
using API_Result_Core_6.Models;


namespace API_Result_Core_6.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task Delete(int id);
    }
}
