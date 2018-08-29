using System;
using System.Collections.Generic;

namespace DesignPattern.MementoPattern_备忘录模式_
{
    internal class MobileOwner
    {
        public List<ContactPerson> ContactPeople { get; set; }

        public MobileOwner(List<ContactPerson> contacts)
        {
            ContactPeople = contacts;
        }

        public ContactMemento CreateMemento()
        {
            return new ContactMemento(new List<ContactPerson>(ContactPeople));
        }
        public void RestoreMemento(ContactMemento memento)
        {
            if (memento != null)
            {
                ContactPeople = memento.ContactPeopleBack;
            }
        }

        public void Show()
        {
            foreach (var item in ContactPeople)
            {
                Console.WriteLine("name:" + item.Name + "num" + item.MobileNum);
            }
        }
    }
}
