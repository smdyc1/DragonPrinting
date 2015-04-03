using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DragonPrinting.Models
{
    [DataContract]
    public class ContactFormModel
    {
        [DataMember]
        public List<KeyValuePair<int, string>> SubjectList { get; set; }

        [DataMember(Name = "Subject:", IsRequired = true)]
        public int SubjectSelection { get; set; }

        [DataMember(Name = "Name:", IsRequired = true)]
        public string ContactName { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember(Name = "Phone No:", IsRequired = true)]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "Email:", IsRequired = true)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataMember(Name = "Message:", IsRequired = true)]
        public string Message { get; set; }

        public ContactFormModel()
        {
            SubjectList = new List<KeyValuePair<int, string>>();
            string[] subjects = new string[] { "Enquiry", "Quote", "Other" };
            for (int i = 0; i < subjects.Length; i++)
            {
                SubjectList.Add(new KeyValuePair<int, string>(i, subjects[i]));
            }
        }
    }
}