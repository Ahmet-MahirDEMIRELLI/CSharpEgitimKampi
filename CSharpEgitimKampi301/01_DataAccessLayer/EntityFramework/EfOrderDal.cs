using _01_DataAccessLayer.Abstarct;
using _01_DataAccessLayer.Repositories;
using _01_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{

	}
}
