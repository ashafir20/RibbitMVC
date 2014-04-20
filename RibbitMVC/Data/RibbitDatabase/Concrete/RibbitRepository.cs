﻿using System.Collections.Generic;
using System.Linq;
using RibbitMVC.Models;

namespace RibbitMVC.Data.RibbitDatabase.Concrete
{
    public class RibbitRepository : EfRepository<Ribbit>, IRibbitRepository
    {
        public RibbitRepository(EFDbContext context, bool sharedContext) 
            : base(context, sharedContext) { }
 
        public Ribbit GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Ribbit> GetFor(User user)
        {
            return user.Ribbits.OrderByDescending(r => r.DateCreated);
        }

        public void AddFor(Ribbit ribbit, User user)
        {
            user.Ribbits.Add(ribbit);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
    }
}