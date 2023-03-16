using OCCAPP.Models;
using System;
using OCCAPP.Repository;

namespace OCCAPP.Repository
{
    public class UserRequest : IUserRequest
    {
        //representative of db backend
        private StudentRequest[] Requests;

        void IUserRequest.SendRequest()
        {
            throw new NotImplementedException();
        }
    }
}
