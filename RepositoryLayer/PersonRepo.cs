using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace RepositoryLayer
{

    public class PersonRepo : IRepoManager<PersonDomain>
    {
        
        
        ClinicContext _context=new ClinicContext();
        public bool Add(PersonDomain Person)
        {
            try
            {
                _context.Add(Person);
                return _context.SaveChanges() > 0;

            }
            catch(Exception ex) 
            { return false; }
        }

        public bool DeleteByID(long ID)
        {
            try
            {
                var Person = _context.People.FirstOrDefault(p => p.PersonID == ID);
                _context.Remove(Person);
                return _context?.SaveChanges() > 0;

            }
            catch (Exception ex)
            { return false; }
        }

        public ICollection<PersonDomain> GetAll()
        {
            try
            {
                return _context.People.Select(p => p).ToList();

            }
            catch(Exception ex)
            {
                return new List<PersonDomain>();
            }
        }

        public PersonDomain GetByID(long ID)
        {
            try
            {
                return _context.People.FirstOrDefault(p => p.PersonID == ID)
                            ?? new PersonDomain();

            }
            catch (Exception ex)
            {
                return new PersonDomain();
            }
        }
        public PersonDomain GetByName(string Name)
        {
            try
            {
                return _context.People.FirstOrDefault(p => p.Name == Name)
                            ?? new PersonDomain();

            }
            catch (Exception ex)
            {
                return new PersonDomain();
            }
        }
        public bool Update(PersonDomain Person)
        {
            try
            {
                _context.Update(Person);
                //_context.Entry(Person).State = EntityState.Mopifiep;
                return _context.SaveChanges() > 0;

            }
            catch (Exception ex)
            { return false; }
        }
         //Do not use (using to dispose) because data is stored in context.Local and context must be open .. Collections have ref of the context.Local Data
        public void DisposeContext()
        {
            _context.Dispose();
        }
        
    }
}
