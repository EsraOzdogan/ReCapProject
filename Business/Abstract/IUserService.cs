﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        /*IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);*/

        //IDataResult<User> GetById(int id);

        //IDataResult<List<User>> GetAll();

        //IDataResult<List<OperationClaim>> GetClaims(User user);

        //IDataResult<User> GetByMail(string userMail);

        //// IDataResult<UserDetailDto> GetUserDetailByMail(string userMail);

        //IResult Add(User user);

        //IResult Update(User user);

        ////  IResult UpdateUserDetails(UserDetailForUpdateDto userDetailForUpdate);

        //IResult Delete(User user);


        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
