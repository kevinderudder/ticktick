using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTick.Models.Dtos;

namespace TickTick.Models
{
    public class Person : BaseAuditableEntity, IEquatable<Person>
    {
        public Guid PublicId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<Location>? Addresses { get; set; }
        public bool IsDeleted { get; private set; }

        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public void Update(PersonDto dto)
        {
            this.FirstName = dto.FirstName;
            this.LastName = dto.LastName;
            this.MiddleName = dto.MiddleName;
            this.DateOfBirth = dto.DateOfBirth;
            this.Email = dto.Email;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }

        public void AddLocation(Location loc)
        {
            if (this.Addresses == null)
            {
                this.Addresses = new List<Location>();
            }
            this.Addresses.Add(loc);
        }

        public void RemoveLocation(Location loc)
        {
            if (this.Addresses != null)
            {
                this.Addresses.Remove(loc);
            }
        }

        public void RemoveLocation(long id)
        {
            if (this.Addresses != null)
            {
                this.Addresses.Remove(this.Addresses.FirstOrDefault(l => l.Id == id));
            }
        }
        
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public bool Equals(Person? other)
        {
            if (!string.IsNullOrEmpty(this.SocialSecurityNumber) && !string.IsNullOrEmpty(other?.SocialSecurityNumber))
            {
                return this.SocialSecurityNumber == other.SocialSecurityNumber;
            }
            else
            {
                return this.PublicId == other?.PublicId;
            }
        }

        public PersonDto ConvertToDto()
        {
            return new PersonDto()
            {
                PublicId = this.PublicId,
                FirstName = this.FirstName,
                LastName = this.LastName,
                MiddleName = this.MiddleName,
                DateOfBirth = this.DateOfBirth,
                Email = this.Email
            };
        }

        public void CreatePublicId()
        {
            this.PublicId = Guid.NewGuid();
        }
    }
}
