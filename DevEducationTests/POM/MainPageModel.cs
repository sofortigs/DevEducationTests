using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class MainPageModel
    {
        public string mainLabelTagName = "h1";

        public string courseMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduatesMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a";
        public string newsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a";
        public string blogMenuButtonXPath = "/html/body/div/div[1]/header/div/div[1]/nav/ul/li[4]/a";
        public string aboutUsMenuButtonXPath = "/html/body/div/div[1]/header/div/div[1]/nav/ul/li[5]/a";
        public string contactsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a";
        public string selectLanguageButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/button";
        public string languageSelectButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/ul/li[3]/a";
        public string faqButtonXPath = "/html/body/div[1]/footer/div/nav/ul/li[7]/a";
        public string privacyPoliceXPath = "/html/body/div[1]/footer/div/div[1]/a";

        public string kyivContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[2]";
        public string peterburgContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[4]";
        public string kharkovContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[5]";

        public string dneprCourseButtonXPath = "/html/body/div[1]/main/section[1]/div/div/ul/li[1]/a";
        public string kyivCourseButtonXPath = "/html/body/div[1]/main/section[1]/div/div/ul/li[2]/a";
        public string bakuCourseButtonXPath = "/html/body/div[1]/main/section[1]/div/div/ul/li[3]/a";
        public string peterburgCourseButtonXPath = "/html/body/div[1]/main/section[1]/div/div/ul/li[4]/a";
        public string kharkovCourseButtonXPath = "/html/body/div[1]/main/section[1]/div/div/ul/li[5]/a";

        public string uaLanguageButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/ul/li[2]/a";
        public string azLanguageButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/ul/li[4]/a";

        public string sitePeterburgCoursesXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[4]/span[2]";
        public string siteKyivCoursesXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[1]/span[2]";
        public string siteDneprCoursesXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[2]/span[2]";
        public string siteKharkovCoursesXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[3]/span[2]";
        public string siteBakuCoursesXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[5]/span[2]";

        public string articleNewsButtonXPath = "/html/body/div[1]/main/div/div/div[1]/div/ul/li[1]/figure/a";

        public string biographyGonzovButtonXPath = "/html/body/div[1]/main/div[3]/div/div/a";

        

    }
}
