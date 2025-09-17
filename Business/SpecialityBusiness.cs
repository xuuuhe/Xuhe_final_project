using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
using System.Data;
namespace Business
{
    public class SpecialityBusiness
    {
        public DataTable GetSpecialityBySid(SpecialityEntity ce)
        {
            string sqlText = "select * from Speciality where sid=@sid";
            string[] paras = { "@sid" };
            object[] values = { ce.Sid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values); 
            return dt;
        }
        public int InsertSpeciality(SpecialityEntity ce)
        {
            string sqlText = "insert into Speciality values(@imgurl,@sname,@currentlysold,@tid,@soldprice,@weight,@currentlystock)";
            string[] paras = { "@imgurl", "@sname", "@currentlysold", "@tid", "@soldprice", "@weight", "@currentlystock" };
            object[] values = { ce.Imgurl, ce.Sname, ce.Currentlysold, ce.Tid, ce.Soldprice, ce.Weight, ce.Currentlystock };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetSpecialityInfo()
        {
            string sqlText = "select * from Speciality";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public DataTable GetSpecialityInfo1()
        {
            string sqlText = "select top 3 * from Speciality";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public DataTable GetSpecialityInfo2()
        {
            string sqlText = "select * from Speciality order by soldprice desc";
            DataTable dt = DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public DataTable GetSpecialityInfo3()
        {
            string sqlText = "select * from Speciality order by currentlysold desc";
            DataTable dt = DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public int UpdateSpeciality(SpecialityEntity ce)
        {
            string sqlText = "update Speciality set sname=@sname,tid=@tid,soldprice=@soldprice,weight=@weight,currentlystock=@currentlystock  where sid=@sid";
            string[] paras = { "@sname", "@tid", "@soldprice", "@weight", "@currentlystock", "@sid" };
            object[] values = { ce.Sname, ce.Tid, ce.Soldprice, ce.Weight, ce.Currentlystock, ce.Sid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }

        public DataTable GetSpecialityBySname(SpecialityEntity ce)
        {
            string sqlText = "select * from Speciality where sname like @sname";
            string[] paras = { "@sname" };
            object[] values = { "%" + ce.Sname + "%" };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
        public DataTable GetSpecialityByTid(SpecialityEntity ce)
        {
            string sqlText = "select * from Speciality where tid=@tid";
            string[] paras = { "@tid" };
            object[] values = { ce.Tid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
        public int UpdateSpecialityCurrentlysold(SpecialityEntity ce)
        {
            string sqlText = "update Speciality set currentlysold=@currentlysold + currentlysold,currentlystock=currentlystock-@currentlysold   where sid=@sid";
            string[] paras = { "@currentlysold", "@sid" };
            object[] values = { ce.Currentlysold, ce.Sid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public int DeleteSpecialityBySid(SpecialityEntity ce)
        {
            string sqlText = "delete from Speciality where sid=@sid";
            string[] paras = { "@sid" };
            object[] values = { ce.Sid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
    }
}
