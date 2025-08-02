using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
 

namespace RepositoryLayer
{

    public class DoctorRepo : IRepoManager<DoctorDomain>
    {
        //PresentationLayer => Biz => DA => Domain
        //i made 4 layers because DA uses(context) and context depends on Entities (Domains) so it must call the Domain Layer (Entities)
        private ClinicContext _context=new ClinicContext();

        public bool Add(DoctorDomain doctor)
        {
            try
            {
                _context.Add(doctor);
                return _context.SaveChanges() > 0;

            }
            catch(Exception ex) 
            { return false; }
        }

        public bool DeleteByID(long ID)
        {
            try
            {
                var doctor = _context.Doctors.FirstOrDefault(d => d.DoctorID == ID);
                _context.Remove(doctor);
                return _context.SaveChanges() > 0;

            }
            catch (Exception ex)
            { return false; }
        }

        public ICollection<DoctorDomain> GetAll()
        {
            try
            {
                return _context.Doctors.Select(d => d).ToList();

            }
            catch(Exception ex)
            {
                return new List<DoctorDomain>();
            }
        }
        public IQueryable<DoctorFullData> GetAllFullData()
        {
            try
            {
                return from d in _context.Doctors.Include(d => d.Person)
                       select new DoctorFullData()
                       {
                           Specialization = d.Specialization,
                           DoctorID = d.DoctorID,
                           Name = d.Person.Name
                       };

            }
            catch (Exception ex)
            {
                // Catch the exception and return an empty IQueryable if there is an error
                return Enumerable.Empty<DoctorFullData>().AsQueryable();
            }
        }
        public DoctorDomain GetByID(long ID)
        {
            try
            {
                return _context.Doctors.FirstOrDefault(d => d.DoctorID == ID)
                                       ?? new DoctorDomain();

            }
            catch (Exception ex)
            {
                return new DoctorDomain();
            }
        }

        public bool Update(DoctorDomain doctor)
        {
            try
            {
                //Update() before save for (Detached objects)
                _context.Update(doctor);
                //_context.Entry(doctor).State = EntityState.Modified;
                return _context.SaveChanges() > 0;

            }
            catch (Exception ex)
            { return false; }
        }

        public void DisposeContext()
        {
            _context.Dispose();
        }

    }
}
