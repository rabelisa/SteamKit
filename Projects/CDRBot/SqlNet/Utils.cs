﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SqlNet
{
    static class Utils
    {
        public static T GetAttribute<T>( this MemberInfo mi )
            where T : Attribute
        {
            T[] attribs = ( T[] )mi.GetCustomAttributes( typeof( T ), false );

            if ( attribs == null || attribs.Length == 0 )
                return null;

            return attribs[ 0 ];
        }
    }
}
