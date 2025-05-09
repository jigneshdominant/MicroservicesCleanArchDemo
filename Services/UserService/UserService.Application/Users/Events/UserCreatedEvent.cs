using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Users.Events
{
    public class UserCreatedEvent : INotification
    {
        public string EmailID { get; set; }
        public string UserName { get; set; }

        public UserCreatedEvent(string emailId, string userName)
        {
            EmailID = emailId;
            UserName = userName;
        }
    }
}
