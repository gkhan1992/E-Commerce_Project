﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
		Task<bool> AddAsync(T model); //gelen modeli ekle
		Task<bool> AddRangeAsync(List<T> datas); //birden fazla koleksiyonu ekle
		bool Remove(T model);
		bool RemoveRange(List<T> datas);
		Task <bool> RemoveAsync (string id);
		bool Update(T model);

		Task<int> SaveAsync();

	}
}
