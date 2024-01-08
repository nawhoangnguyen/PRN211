using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV2
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _city; //đặc tính, thuộc tính mô tả 1 object
        //phía hậu trường, nội tại của mỗi object
        //back field, backed field


        public Student(string id, string name, string email, string phone, string city)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _city = city;
        }

        //public string Id { get { return _id; } }
        //public string Name { get { return _name; } }
        //public string Email { get { return _email; } }
        //public string Phone { get { return _phone; } }
        //public string City { get { return _city; } }


        public string GetCity()
        {
            return _city;
        }
        //style truyền thống
        //public string GetCity {  return _city;  }

        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public override string? ToString()
        {
            return @$"Student profile   
                                           Id : {_id} 
                                         Name : {_name} 
                                        Email : {_email} 
                                        Phone : {_phone}
                                         City : {_city}";
        }



        //Id là một cái hàm bao cho hai hàm GetId và SetId
        //lúc này student.id rất tự nhin theo 2 cách
        //Id => lấy ra _Id của sv, Id là kiểu string -> gt()
        //ID => "Id mới" => set()
        //1 biến public dùng cho 2 mục đích get() set() backed field

        // VIẾT GỘP CHO SET VÀ GET ĐỂ TỰ NHIÊN KHI NÓI VỀ Id của 1 sv


    }
}
