﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDengineTest
{
    public partial class ORMTest
    {
        public static void CodeFirst(SqlSugarClient db)
        {
            CodeFirst1(db);

            db.CodeFirst.InitTables<CodeFirst03>();
            db.Insertable(new CodeFirst03()
            {
                Ts = DateTime.Now,
                Boolean = true,
                Char = 'a',
                Decimal = Convert.ToDecimal(18.2),
                Int16 = 16,
                Int32 = 32,
                Int64 = 64,
                String = "string",
                SByte=3,
                Byte = 2,
                Decimal2 = Convert.ToDecimal(18.3),
                Double = Convert.ToDouble(18.44),
                Float = Convert.ToSingle(18.45),
                String2 = "2",
                 UInt16=116,
                  UInt32=332,
                   UInt64=664
            }).ExecuteCommand();
            var dt = db.Ado.GetDataTable("select * from  CodeFirst03 ");
            var list3 = db.Queryable<CodeFirst03>().ToList();
        }

        private static void CodeFirst1(SqlSugarClient db)
        {
            db.CodeFirst.InitTables<CodeFirst01>();
            db.Insertable(new CodeFirst01() { Boolean = true, Ts = DateTime.Now }).ExecuteCommand();
            var list = db.Queryable<CodeFirst01>().ToList();
        }
    }
}
