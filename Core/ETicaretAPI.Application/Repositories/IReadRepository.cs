using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
	{
		IQueryable<T> GetAll(); //Hangi türdeysek(örnek:product) getall fonksiyonunu çağırınca bütün productları getir(sorgu için ıqueryable)
		IQueryable<T> GetWhere(Expression<Func<T, bool>> method); //sorguya uygun olanları getirir çoğul
		Task <T> GetSingleAsync(Expression<Func<T, bool>> method); //sorguya uygun ilk olanı getirir tekil
		Task <T> GetByIdAsync(string id); //ıd ye uygun olanı getirir
	}
}
