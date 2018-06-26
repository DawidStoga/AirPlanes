using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMessagesInBlob.Model
{
    class Person:IModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Address { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
