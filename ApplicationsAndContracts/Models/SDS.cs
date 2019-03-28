using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    class SDS
    {
        public static SDS CreateFrom(DataRow row)
        {
            var result = new SDS();
            result.UserRole = row.Field<string>("UserRole");
            result.UserName = row.Field<string>("UserName");
            result.UserDepartment = row.Field<string>("UserDepartment");
            result.Date = row.Field<DateTime>("Date");
            return result;
        }

        private SDS()
        {
        }

        public static string FormatUserRole(SDS sds)
        {
            if (sds == null) return ToEmpty("userRole");
            return sds.ToString("userRole");
        }

        public static string FormatUserName(SDS sds)
        {
            if (sds == null) return ToEmpty("userName");
            return sds.ToString("userName");
        }

        public static string FormatUserDepartment(SDS sds)
        {
            if (sds == null) return ToEmpty("userDepartment");
            return sds.ToString("userDepartment");
        }

        public static string FormatDate(SDS sds)
        {
            if (sds == null) return ToEmpty("date");
            return sds.ToString("date");
        }

        public string ToString(string format)
        {
            if (format == "userRole")
                return string.Format("Роль пользователя: {0}", this.UserRole);
            if (format == "userName")
                return string.Format("Пользователь: {0}", this.UserName);
            if (format == "userDepartment")
                return string.Format("Отдел: {0}", this.UserDepartment);
            if (format == "date")
                return string.Format("Дата: {0}", this.Date.ToShortDateString());
            throw new ApplicationException("Неверный формат");
        }

        public static string ToEmpty(string format)
        {
            if (format == "userRole")
                return string.Format("(пусто)");
            if (format == "userName")
                return string.Format("(пусто)");
            if (format == "userDepartment")
                return string.Format("(пусто)");
            if (format == "date")
                return string.Format("(пусто)");
            throw new ApplicationException("Неверный формат");
        }

        public static bool SetButtonsState(SDS sds)
        {
            if (sds.UserRole == "941_write" || sds.UserRole == "941_plan" || sds.UserRole == "db_owner") return true;
            if (sds.UserRole == "941_read") return false;
            throw new ApplicationException("Пользователь не включен ни в одну из ролей");
        }

        public string UserRole { get; private set; }
        public string UserName { get; private set; }
        public string UserDepartment { get; private set; }
        public DateTime Date { get; private set; }
    }
}

