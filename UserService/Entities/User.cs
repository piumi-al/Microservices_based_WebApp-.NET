﻿/* IT19207964
 * Weerasooriya K.T.N.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Entites
{
    public class User : BaseEntity
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Contact { get; set; }

        public String Address { get; set; }

        public String Email { get; set; }

    }
}
