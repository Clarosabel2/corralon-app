using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public enum BE_EventType
    {
        LOGIN = 1,
        LOGOUT = 2,
        CHANGE_LANGUAGE = 3,
        UPDATE_DATA_USER = 4,
        CREATE_SALE = 5,
        CREATE_USER = 6,
        CREATE_EMPLOYEE = 7,
        CREATE_CLIENT = 8,
        CREATE_PRODUCT = 9,
        CREATE_LANGUAGE = 10,
        DISPATCH_ORDER = 11,
        CREATE_SUPPLIER = 12,
    }
}
