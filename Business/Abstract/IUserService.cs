﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Update(User user);
        IResult UpdateUserDetails(UserDetailForUpdateDto userDetailForUpdate);
        IResult Delete(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string userMail);
        IDataResult<UserDetailDto> GetUserDetailByMail(string userMail);


        /*List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);*/
    }
}
