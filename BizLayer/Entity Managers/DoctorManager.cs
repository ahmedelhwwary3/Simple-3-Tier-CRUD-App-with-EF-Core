using DomainLayer.Entities;
using RepositoryLayer;

namespace BizLayer
{

    public class DoctorManager
    {


        readonly static DoctorRepo DoctorData = new DoctorRepo();


        public static List<DoctorDomain> GetAllDoctors()
        {
            try
            {
                return DoctorData.GetAll().ToList();
            }
            catch (Exception ex)
            {
                return new List<DoctorDomain>();
            }
        }
        public static DoctorDomain GetDoctorByID(int ID)
        {

            try
            {
                return DoctorData.GetByID(ID);
            }
            catch (Exception ex)
            {
                return new DoctorDomain();
            }

        }
        public static bool DeleteDoctorByID(long ID)
        {
            try
            {
                return DoctorData.DeleteByID(ID);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool UpdateDoctorByID(DoctorDomain dr)
        {
            try
            {
                return DoctorData.Update(new DoctorDomain() { DoctorID = dr.DoctorID, PersonID = dr.PersonID, Specialization= dr.Specialization });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool AddNewDoctor(DoctorDomain dr)
        {
            try
            {
                //EF handles Auto Increment ID in Add()
                return DoctorData.Add(new DoctorDomain() { PersonID = dr.PersonID, Specialization = dr.Specialization });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<DoctorFullData> GetAllDoctorsFullData()
        {
            try
            {
                return DoctorData.GetAllFullData().ToList();
            }
            catch (Exception ex)
            {
                return new List<DoctorFullData>();
            }
        }



















    }
}
