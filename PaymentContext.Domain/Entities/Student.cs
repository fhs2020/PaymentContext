using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;

            if(firstName.Length == 0)
                throw new Exception("Nome invalido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public List<Subscription> Subscriptions { get; set; }

        public void AddSubscription(Subscription subscription)
            {
            
            }
    }
}
