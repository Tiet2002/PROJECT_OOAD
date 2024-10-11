using PROJECT_OOAD;
using PROJECT_OOAD.DAL;
using PROJECT_OOAD.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace PROJECT_OOAD
{
    [Authorize]
    public class Intranet
    {
        public static dynamic GetCookieValue()
        {
            try
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

                string obj = ticket.UserData;
                dynamic data = JObject.Parse(obj);

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public static void SetCookieValue(string UserName, User CurrentUser)
        //{
        //    FormsAuthentication.SetAuthCookie(UserName, false);

        //    var json = new JavaScriptSerializer().Serialize(CurrentUser);

        //    FormsAuthenticationTicket ticket = null;
        //    ticket = new FormsAuthenticationTicket(1, UserName, DateTime.Now,
        //            DateTime.Now.AddMinutes(50), true,
        //           json);

        //    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName);
        //    cookie.Value = FormsAuthentication.Encrypt(ticket);

        //    HttpContext.Current.Response.SetCookie(cookie);

        //}
        public static string Message(string type, string mes)
        {
            string Msg = "";
            if (type == "Success")
            {
                Msg = "<div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">" +
                        mes +
                        "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">" +
                            "<span aria-hidden=\"true\">&times;</span>" +
                        "</button>" +
                    "</div>";
            }
            else if (type == "Error")
            {
                Msg = "<div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">" +
                        mes +
                        "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">" +
                            "<span aria-hidden=\"true\">&times;</span>" +
                        "</button>" +
                    "</div>";
            }
            else if (type == "Warning")
            {
                Msg = "<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">" +
                        mes +
                        "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">" +
                            "<span aria-hidden=\"true\">&times;</span>" +
                        "</button>" +
                    "</div>";
            }
            return Msg;
        }

        public static string encrypt(string clearText)
        {
            string EncryptionKey = "AMAKV2SPBNI99212B";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        //This Function not using
        //public string Decrypt(string cipherText)
        //{
        //    string EncryptionKey = "AMAKV2SPBNI99212B";
        //    byte[] cipherBytes = Convert.FromBase64String(cipherText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(cipherBytes, 0, cipherBytes.Length);
        //                cs.Close();
        //            }
        //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        //        }
        //    }
        //    return cipherText;
        //}

        //public static List<Menu> MainMenu(string StaffId)
        //{
        //    StaffId = GetCookieValue().Id;
        //    dynamic model = new ExpandoObject();
        //    MenuDAL orDal = new MenuDAL();
        //    model = orDal.GetMainMenu(StaffId);
        //    return model;
        //}
        //public static List<Menu> SubMenu1(string StaffId, int Mid)
        //{
        //    StaffId = GetCookieValue().Id;
        //    dynamic model = new ExpandoObject();
        //    MenuDAL orDal = new MenuDAL();
        //    model = orDal.GetSubMenu1(StaffId, Mid);
        //    return model;
        //}
        //public static List<Menu> SubMenu2(string StaffId, int Mid)
        //{
        //    StaffId = GetCookieValue().Id;
        //    dynamic model = new ExpandoObject();
        //    MenuDAL orDal = new MenuDAL();
        //    model = orDal.GetSubMenu2(StaffId, Mid);
        //    return model;
        //}

        public static string GetApplPath()
        {
            string Url = HttpContext.Current.Request.RequestContext.RouteData.Values["controller"].ToString();
            //Url = "~/" + Url + "/";
            return Url;
        }
        //public static string CheckPermissionButton(string StaffId, string Url)
        //{
        //    StaffId = GetCookieValue().Id;
        //    Url = GetApplPath();

        //    dynamic model = new ExpandoObject();
        //    PermissionDAL orDal = new PermissionDAL();
        //    model = orDal.CheckPermission(StaffId, Url);

        //    string Str = "<script>";
        //    if (model.View == 0)
        //    {
        //        Str += "$('.btn_pView').remove();";
        //    }
        //    if (model.Add == 0)
        //    {
        //        Str += "$('.btn_pAdd').remove();";
        //    }
        //    if (model.Update == 0)
        //    {
        //        Str += "$('.btn_pUpdate').remove();";
        //    }
        //    if (model.Delete == 0)
        //    {
        //        Str += "$('.btn_pDelete').remove();";
        //    }
        //    if (model.Approve == 0)
        //    {
        //        Str += "$('.btn_pApprove').remove();";
        //    }
        //    Str += "</script>";
        //    return Str;
        //}
    }
}