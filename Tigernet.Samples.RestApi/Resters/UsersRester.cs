﻿using Tigernet.Hosting.Actions;
using Tigernet.Hosting.Attributes.HttpMethods;
using Tigernet.Hosting.Attributes.Resters;
using Tigernet.Samples.RestApi.Abstractions;
using Tigernet.Samples.RestApi.Models;
namespace Tigernet.Samples.RestApi.Resters
{
    [ApiRester]
    public class UsersRester : ResterBase
    {
        private readonly IUserClever userClever;

        public UsersRester(IUserClever userClever)
        {
            this.userClever = userClever;
        }


        [Getter("/all")]
        public object GetAll()
        {
            return Ok(userClever.GetAll());
        }

        [Getter]
        public object Get()
        {
            return Ok(userClever.Get(1));
        }

        [Poster("/new")]
        public object Add()
        {
            User user = new User()
            {
                Id = 7,
                Name = "Ikrom",
                Age = 28

            };

            return Ok(userClever.Add(user));
        }
    }
}
