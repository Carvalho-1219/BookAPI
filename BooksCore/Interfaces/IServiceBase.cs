﻿using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RollBack_Core.Interface
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        //User service Interface with Post, Put, Update and remove  method
        void Add(TEntity obj);

        Task<TEntity> GetById(ObjectId id);

        Task<IEnumerable<TEntity>> GetAll();

        void Update(TEntity obj, string id);

        void AddBook(TEntity obj, string id);

        void removeBook(TEntity obj, string id);

        void Remove(ObjectId id);

        Task<TEntity> FindByName(string name);

        Task<TEntity> GetByParentID(string parentID);
    }
}