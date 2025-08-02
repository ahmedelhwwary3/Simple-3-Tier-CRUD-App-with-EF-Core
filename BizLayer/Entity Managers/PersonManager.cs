using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BizLayer
{

    public class PersonManager
    {
        readonly static PersonRepo PersonData=new PersonRepo();


        public static List<PersonDomain> GetAllPeople()
        {
            try
            {
                return PersonData.GetAll().ToList();
            }
            catch (Exception ex)
            {
                return new List<PersonDomain>();
            }
        }
        public static PersonDomain GetPerson(int ID)
        {

            try
            {
                return PersonData.GetByID(ID);
            }
            catch (Exception ex)
            {
                return new PersonDomain();
            }

        }
        public static PersonDomain GetPersonByName(string Name)
        {
            try
            {
                return PersonData.GetByName(Name);
            }
            catch (Exception ex)
            {
                return new PersonDomain();
            }
        }
        public static bool DeletePersonByID(long ID)
        {
            try
            {
                return PersonData.DeleteByID(ID);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool UpdatePersonByID(int ID,DateTime DateOfBirth,string Name,char Gender,string PhoneNumber,string Email,string Address,int DoctorID)
        {
            try
            {
                return PersonData.Update(new PersonDomain() { PersonID= ID ,DateOfBirth= DateOfBirth ,Name= Name , Gender= Gender ,PhoneNumber=PhoneNumber,Email=Email,Address=Address});
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool AddPerson(DateTime DateOfBirth, string Name, char Gender, string PhoneNumber, string Email, string Address, int DoctorID)
        {
            try
            {
                //EF handles Auto Increment ID in Add()
                return PersonData.Add(new PersonDomain() { DateOfBirth = DateOfBirth, Name = Name, Gender = Gender, PhoneNumber = PhoneNumber, Email = Email, Address = Address });
            }
            catch (Exception ex)
            {
                return false;
            }
        }














        
    }
}
