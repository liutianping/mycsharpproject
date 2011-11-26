using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cjgl
{
    public class SpecialtyOperation
    {
        private static DataAccess dataAccess = new DataAccess();
        public static bool insertSpecialty(SpecialtyInfoData specialtyinfoData)
        {
            //数据插入
            string sql = string.Format("insert into specialtyInfo(specialtyid,specialtymc) values ({0},{1})",specialtyinfoData.Specialtyid,specialtyinfoData.Specialtymc);
            return dataAccess.ExecuteSQL(sql);

        }
        public static bool updataSpecialty(SpecialtyInfoData specialty)
        {
            //数据修改
            string sql = string.Format("update specialtyinfo set specialtymc='{1} where specialtyid='{0}'",specialty.ToString,specialty.Specialtymc);
            return dataAccess.ExecuteSQL(sql);
        }
        public static bool deleteSpecialty(string specialtyid)
        {
            //数据删除
            string sql = string.Format("delete specialtyinfo where specialtyid='{0}'",specialtyid);
            return dataAccess.ExecuteSQL(sql);
        }
        public static DataSet getSpeicalty(SpecialtyInfoData specialtyInfoData)
        {
            string condition = "";
            if (specialtyInfoData.Specialtyid != null && specialtyInfoData.Specialtyid != "")
            {
                condition += " specialtyid='"+specialtyInfoData.Specialtyid+"'";
            }
            if (specialtyInfoData.Specialtymc != null && specialtyInfoData.Specialtymc != "")
            {
                condition += " and specialtymc like '%"+specialtyInfoData.Specialtymc+"%'";
            }
            string sql = "select specialtyid,specialtymc from specialtyinfo where "+condition;
            return dataAccess.GetDataSet(sql,"specialty");
        }
    }
}
