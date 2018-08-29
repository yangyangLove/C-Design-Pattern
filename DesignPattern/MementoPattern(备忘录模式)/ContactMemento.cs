using System.Collections.Generic;

namespace DesignPattern.MementoPattern_备忘录模式_
{
    internal class ContactMemento
    {
        public List<ContactPerson> ContactPeopleBack { get; set; }
        public ContactMemento(List<ContactPerson> contactPeople)
        {
            ContactPeopleBack = contactPeople;
        }
    }
}
