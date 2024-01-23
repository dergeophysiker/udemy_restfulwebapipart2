﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MagicVilla_VillaAPI.Repository.IRepository;

namespace MagicVilla_VillaAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
           // _db.VillaNumbers.Include(u => u.Villa).ToList();
            dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        //"Villa,VillaSpecial"
        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null)
        {

            
            IQueryable<T> query = dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();

            }

            if (filter != null)
            {
                query = query.Where(filter);

            }


            if(includeProperties != null)
            {
                foreach(var property in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)) 
                {
                query = query.Include(property);
                }
            }


            return await query.FirstOrDefaultAsync();
        }

        //https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, int pageSize = 3, int pageNumber = 1)
        {

            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (pageSize > 0)
            {
                if (pageSize > 100)
                {
                    pageSize = 100;
                }
                // if pagesize is 5 and page number is 1
                // 5(1-1)  = 0 skip | so take is 5   ---  skip0.take(5)
                // 5(2-1) ----skip5.take5

                query = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);


            }
            if (includeProperties != null)
			{
				foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(property);
				}
			}



			return await query.ToListAsync();
        }


        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }


    }

}

