﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RibbitMVC.Data.RibbitDatabase.Abstract;

namespace RibbitMVC.Data.RibbitDatabase.Concrete
{
    public class EfRepository<T> : IRepository<T>
        where T : class
    {
        protected DbContext Context;
        protected readonly bool SharedContext;

        public EfRepository(DbContext context) : this(context, false) { }

        public EfRepository(DbContext context, bool sharedContext)
        {
            Context = context;
            SharedContext = sharedContext;
        }

        protected DbSet<T> DbSet
        {
            get { return Context.Set<T>(); }
        }

        public IQueryable<T> All()
        {
            return DbSet.AsQueryable();
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public int Count
        {
            get { return DbSet.Count(); }
        }

        public T Create(T t)
        {
            DbSet.Add(t);
            if (!SharedContext)
            {
                Context.SaveChanges();
            }
            return t;
        }

        public int Delete(T t)
        {
            DbSet.Remove(t);
            if (!SharedContext)
            {
                Context.SaveChanges();
            }
            return 0;
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            var records = FindAll(predicate);
            foreach (var record in records)
            {
                DbSet.Remove(record);
            }
            if (!SharedContext)
            {
                Context.SaveChanges();
            }
            return 0;
        }

        public T Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.SingleOrDefault(predicate);
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, int index, int size)
        {
            var skip = index*size;

            IQueryable<T> query = DbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (skip != 0)
            {
                query = query.Skip(skip);
            }

            return query.Take(size).AsQueryable();
        }

        public int Update(T t)
        {
            var entry = Context.Entry(t);

            DbSet.Attach(t);
            
            entry.State = EntityState.Modified;

            if (!SharedContext)
            {
                return Context.SaveChanges();
            }

            return 0;
        }

        public void Dispose()
        {
            if (!SharedContext && Context != null)
            {
                try
                {
                    Context.Dispose();
                }
                catch { }
            }
        }
    }
}