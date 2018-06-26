using StoreMessagesInBlob.Interfaces;
using StoreMessagesInBlob.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace StoreMessagesInBlob.Service
{
    class Validator1 : IValidator
    {
        Person person;
        public string Validate(IModel model)
        {
            this.person = model as Person;


            if (this.person == null)
            {
                return "Wrong Model";
            }

            return typeof(Validator1).ToString();

        }

        public string Validate()
        {
            throw new NotImplementedException();
        }
    }


    class Validator2 : IValidator
    {

        Customer customer;
        public string Validate(IModel model)
        {
            this.customer = model as Customer;


            if (this.customer == null)
            {
                return "Wrong Model";

            }

           var result = IsEmailValid(customer.Email);


            return typeof(Validator2).ToString();

        }


        private bool IsEmailValid(string email)
        {
            var mailaddress = new  MailAddress(email);
            return (mailaddress != null);

        }

        public string Validate()
        {
            throw new NotImplementedException();
        }
    }

    class DefualValidator : IValidator
    {
        public string Validate(IModel model)
        {
            throw new NotImplementedException();
        }

        public string Validate()
        {
            throw new NotImplementedException();
        }
    }
}
