using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawnh.FAP.StudentManagerV3
{
    internal class Student
    {

		//gõ propfull tab tab giúp ta tự động generate ra backfield + get set
		//get set kiểu có backfield này được gọi là kĩ thuật full property
		//name và các field khác làm tương tự

		private int _id;

		public int MyProperty
		{
			get { return _id; }
			set { _id = value; }
		}

	}
}
