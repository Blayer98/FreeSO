﻿using FSO.Common.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Common.DataService.Framework
{
    public interface IDataServiceProvider
    {
        Task<object> Get(object key);
        void DemandMutation(object entity, MutationType type, string path, object value, ISecurityContext context);

        Type GetKeyType();
        Type GetValueType();
    }

    public enum MutationType
    {
        SET_FIELD_VALUE,
        ARRAY_SET_ITEM,
        ARRAY_REMOVE_ITEM
    }
}
