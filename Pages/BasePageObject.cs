﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class BasePageObject
    {
        protected DriverWrapper driver;

        public virtual void Init(DriverWrapper driver)
        {
            this.driver = driver;
            //InitDriver(driver);
        }

        //private void InitDriver(DriverWrapper driver) => this.driver = driver;

        public static T GetPOM<T>(DriverWrapper driver) where T: BasePageObject, new()
        {
            var pom = new T();
            pom.Init(driver);
            return pom;
        }
    }
}
