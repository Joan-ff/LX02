using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));
        }
    }
    [TestMethod]
    public void TestMethod2()
    {
        Model.UserInfo user = new Model.UserInfo {userName = "Guest", passWord = "sq1.123", type="π‹¿Ì‘±"};
        Console.WriteLine(DAL.UserInfo.Instance.Add(user));
        Console.Writeline(JsonConvert.SerializeObject(DAL.UserInfo.Instance.CetAl1());
        user.qq = "381065490";
        Console.WriteLine(DAL.UserInfo.Instance.Upate(user));
        var model = DAL.UserInfo.Instance.GetModel("Guest");
        Console.WritelLine(JsonConvert.Serialize0bject(model));
        Console.WriteLine(DAL.UserInfo.Instance.Delete("Guest"));
        var page = DAL.UserInfo.Instance.GetPage(new Model.Page { pageIndex = 2, pageSize = 2 });
        Console.WriteLine(JsonConvert.Serialize0bject(page));
        Console.WriteLine(DAL.UserInfo.Instance.GetCount());
    }
}
