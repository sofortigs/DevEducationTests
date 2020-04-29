using DevEducationTests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class MainPageTest : BaseDriver
    {
        MainPageModel pageModel;
        CoursesPageModel coursesModel;
        GraduatesPageModel graduatesModel;
        NewsPageModel newsModel;
        BlogPageModel blogModel;
        AboutUsPageModel aboutUsModel;
        ContactsPageModel contactsModel;
        LanguagePageModel languageModel;
        FAQPageModel faqModel;
        PrivacyPolicyPageModel privacyPolici;

        ContactKyivPage contactKyivPage;
        ContactDneprPage contactDneprPage;
        ContactPeterburgPage contactPeterburgPage;
        ContactKharkovPage contactKharkovPage;

        CoursesDneprPage coursesDneprPage;
        CoursesKyivPage coursesKyivPage;
        CoursesBakuPage coursesBakuPage;
        CoursesPeterburgPage coursesPeterburgPage;
        CoursesKharkovPage coursesKharkovPage;

        UaLanguageSelect uaLanguageSelect;
        AzLanguageSelect azLanguageSelect;

        SitePeterburgCourses sitePeterburgCourses;
        SiteKyivCourses siteKyivCourses;
        SiteDneprCourses siteDneprCourses;
        SiteKharkovCourses siteKharkovCourses;
        SiteBakuCourses siteBakuCourses;

        ArticleNewsPage articleNewsPage;

        BiographyGonzovPage bioGonzovPage;

        

        public MainPageTest()
        {
            pageModel = new MainPageModel();
            coursesModel = new CoursesPageModel();
            graduatesModel = new GraduatesPageModel();
            newsModel = new NewsPageModel();
            blogModel = new BlogPageModel();
            aboutUsModel = new AboutUsPageModel();
            contactsModel = new ContactsPageModel();
            languageModel = new LanguagePageModel();
            faqModel = new FAQPageModel();
            privacyPolici = new PrivacyPolicyPageModel();

            contactKyivPage = new ContactKyivPage();
            contactDneprPage = new ContactDneprPage();
            contactPeterburgPage = new ContactPeterburgPage();
            contactKharkovPage = new ContactKharkovPage();

            coursesDneprPage = new CoursesDneprPage();
            coursesKyivPage = new CoursesKyivPage();
            coursesBakuPage = new CoursesBakuPage();
            coursesPeterburgPage = new CoursesPeterburgPage();
            coursesKharkovPage = new CoursesKharkovPage();

            uaLanguageSelect = new UaLanguageSelect();
            azLanguageSelect = new AzLanguageSelect();

            sitePeterburgCourses = new SitePeterburgCourses();
            siteKyivCourses = new SiteKyivCourses();
            siteDneprCourses = new SiteDneprCourses();
            siteKharkovCourses = new SiteKharkovCourses();
            siteBakuCourses = new SiteBakuCourses();

            articleNewsPage = new ArticleNewsPage();
            

            bioGonzovPage = new BiographyGonzovPage();


            
            
        }
    

        [Test]
        public void ChekMainLabe()
        {
           driver.Url = Urls.mainPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(pageModel.mainLabelTagName));
            string ActResult = mainLabel.Text;
            Assert.AreEqual("Международный IT-колледж", ActResult);
        }

        [Test]
        public void CheckCourses()
        {
            driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(pageModel.courseMenuButtonXPath));
            coursesButton.Click();
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckGraduates()
        {
            driver.Url = Urls.mainPage;
            IWebElement graduatesButton = driver.FindElement(By.XPath(pageModel.graduatesMenuButtonXPath));
            graduatesButton.Click();
            IWebElement ourGraduatesName = driver.FindElement(By.TagName(graduatesModel.ourGraduatesTageName));
            string actResult = ourGraduatesName.Text;
            Assert.AreEqual("Наши выпускники", actResult);
        }

        [Test]
        public void CheckNews()
        {
            driver.Url = Urls.mainPage;
            IWebElement newsButton = driver.FindElement(By.XPath(pageModel.newsMenuButtonXPath));
            newsButton.Click();
            IWebElement ourNews = driver.FindElement(By.TagName(newsModel.ourNewsPage));
            string actResult = ourNews.Text;
            Assert.AreEqual("Новости", actResult);
        }

        [Test]
        public void CheckBlog()
        {
            driver.Url = Urls.mainPage;
            IWebElement blogButton = driver.FindElement(By.XPath(pageModel.blogMenuButtonXPath));
            blogButton.Click();
            IWebElement ourBlog = driver.FindElement(By.TagName(blogModel.ourBlogPage));
            string actResult = ourBlog.Text;
            Assert.AreEqual("Блог", actResult);
        }

        [Test]
        public void CheckAboutUs()
        {
            driver.Url = Urls.mainPage;
            IWebElement aboutUsButton = driver.FindElement(By.XPath(pageModel.aboutUsMenuButtonXPath));
            aboutUsButton.Click();
            IWebElement aboutUs = driver.FindElement(By.TagName(aboutUsModel.aboutUsPage));
            string actResult = aboutUs.Text;
            Assert.AreEqual("О нас", actResult);
        }

        [Test]
        public void CheckContacts()
        {
            driver.Url = Urls.mainPage;
            IWebElement contactsButton = driver.FindElement(By.XPath(pageModel.contactsMenuButtonXPath));
            contactsButton.Click();
            IWebElement ourContacts = driver.FindElement(By.TagName(contactsModel.ourContactsPage));
            string actResult = ourContacts.Text;
            Assert.AreEqual("Наши контакты", actResult);
        }

        [Test]
        public void CheckLanguage()
        {
            driver.Url = Urls.mainPage;
            IWebElement selectLanguageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXPath));
            selectLanguageButton.Click();
            IWebElement languageSelectButton = driver.FindElement(By.XPath(pageModel.languageSelectButtonXPath));
            languageSelectButton.Click();
            IWebElement selectLanguage = driver.FindElement(By.TagName(languageModel.selectLanguagePage));
            string actResult = selectLanguage.Text;
            Assert.AreEqual("International IT College", actResult);
        }

        [Test]
        public void CheckFAQ()
        {
            driver.Url = Urls.mainPage;
            IWebElement faqButton = driver.FindElement(By.XPath(pageModel.faqButtonXPath));
            faqButton.Click();
            IWebElement faqFAQ = driver.FindElement(By.TagName(faqModel.faqPage));
            string actResult = faqFAQ.Text;
            Assert.AreEqual("FAQ", actResult);
        }

        [Test]
        public void CheckPrivacyPolice()
        {
            driver.Url = Urls.mainPage;
            IWebElement privacyButton = driver.FindElement(By.XPath(pageModel.privacyPoliceXPath));
            privacyButton.Click();
            IWebElement privaciPolice = driver.FindElement(By.TagName(privacyPolici.privacyPolice));
            string actResult = privaciPolice.Text;
            Assert.AreEqual("Политика конфиденциальности", actResult);
        }

        [Test]
        public void CheckKyivAdress()
        {
            driver.Url = Urls.contPage;
            IWebElement kyivButton = driver.FindElement(By.XPath(pageModel.kyivContactsButtonXPath));
            kyivButton.Click();
            IWebElement contactKyivCheck = driver.FindElement(By.XPath(contactKyivPage.ourContactKyivXPath));
            string actResult = contactKyivCheck.Text;
            Assert.AreEqual("ст. метро Васильковская, ул. Сумская,1", actResult);
        }

        [Test]
        public void CheckDneprAdress()
        {
            driver.Url = Urls.contPage;
            IWebElement contactDneprCheck = driver.FindElement(By.XPath(contactDneprPage.ourContactDneprXPath));
            string actResult = contactDneprCheck.Text;
            Assert.AreEqual("ул.Симферопольская, 17", actResult);
        }

        [Test]
        public void CheckPeterburgAress()
        {
            driver.Url = Urls.contPage;
            IWebElement peterburgButton = driver.FindElement(By.XPath(pageModel.peterburgContactsButtonXPath));
            peterburgButton.Click();
            IWebElement contactPeterburgCheck = driver.FindElement(By.XPath(contactPeterburgPage.ourContactPeterburgXPath));
            string actResult = contactPeterburgCheck.Text;
            Assert.AreEqual("площадь Карла Фаберже, 8Б, офис 440\r\nБЦ Золотая Долина", actResult);
        }

        [Test]
        public void CheckKharkovAdress()
        {
            driver.Url = Urls.contPage;
            IWebElement kharkovButton = driver.FindElement(By.XPath(pageModel.kharkovContactsButtonXPath));
            kharkovButton.Click();
            IWebElement contactKharkovCheck = driver.FindElement(By.XPath(contactKharkovPage.ourContactKharkovXPath));
            string actResult = contactKharkovCheck.Text;
            Assert.AreEqual("ул. Донец Захаржевского, 2,\r\nздание Сбербанка, этаж 5", actResult);
        }

        [Test]
        public void CheckCourseDnepr()
        {
            driver.Url = Urls.coursPage;
            IWebElement dneprButton = driver.FindElement(By.XPath(pageModel.dneprCourseButtonXPath));
            dneprButton.Click();
            IWebElement courseDneprCheck = driver.FindElement(By.TagName(coursesDneprPage.ourCourseDnepr));
            string actResult = courseDneprCheck.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckCourseKyiv()
        {
            driver.Url = Urls.coursPage;
            IWebElement kyivButton = driver.FindElement(By.XPath(pageModel.kyivCourseButtonXPath));
            kyivButton.Click();
            IWebElement courseKyivCheck = driver.FindElement(By.TagName(coursesKyivPage.ourCourseKyiv));
            string actResult = courseKyivCheck.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckCourseBaku()
        {
            driver.Url = Urls.coursPage;
            IWebElement bakuButton = driver.FindElement(By.XPath(pageModel.bakuCourseButtonXPath));
            bakuButton.Click();
            IWebElement courseBakuCheck = driver.FindElement(By.TagName(coursesBakuPage.ourCourseBaku));
            string actResult = courseBakuCheck.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckCoursePeterburg()
        {
            driver.Url = Urls.coursPage;
            IWebElement peterburgButton = driver.FindElement(By.XPath(pageModel.peterburgCourseButtonXPath));
            peterburgButton.Click();
            IWebElement coursePeterburgCheck = driver.FindElement(By.TagName(coursesPeterburgPage.ourCoursePeterburg));
            string actResult = coursePeterburgCheck.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckCourseKharkov()
        {
            driver.Url = Urls.coursPage;
            IWebElement kharkovButton = driver.FindElement(By.XPath(pageModel.kharkovCourseButtonXPath));
            kharkovButton.Click();
            IWebElement courseKharkovCheck = driver.FindElement(By.TagName(coursesKharkovPage.ourCourseKharkov));
            string actResult = courseKharkovCheck.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckBioGonzov()
        {
            driver.Url = Urls.aboutPage;
            IWebElement bioButton = driver.FindElement(By.XPath(pageModel.biographyGonzovButtonXPath));
            bioButton.Click();
            IWebElement bioGonzovCheck = driver.FindElement(By.TagName(bioGonzovPage.biographyGonzovInt));
            string actResult = bioGonzovCheck.Text;
            Assert.AreEqual("Вдохновитель", actResult);
        }

        [Test]
        public void CheckUALanguage()
        {
            driver.Url = Urls.mainPage;
            IWebElement selectLanguageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXPath));
            selectLanguageButton.Click();
            IWebElement uaLanguageButton = driver.FindElement(By.XPath(pageModel.uaLanguageButtonXPath));
            uaLanguageButton.Click();
            IWebElement selectLanguage = driver.FindElement(By.TagName(uaLanguageSelect.uaLanguagePage));
            string actResult = selectLanguage.Text;
            Assert.AreEqual("Міжнародний IT-коледж", actResult);
        }

        [Test]
        public void CheckAZLanguage()
        {
            driver.Url = Urls.mainPage;
            IWebElement selectLanguageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXPath));
            selectLanguageButton.Click();
            IWebElement azLanguageButton = driver.FindElement(By.XPath(pageModel.azLanguageButtonXPath));
            azLanguageButton.Click();
            IWebElement selectLanguage = driver.FindElement(By.TagName(azLanguageSelect.azLanguagePage));
            string actResult = selectLanguage.Text;
            Assert.AreEqual("Beynəlxalq İT kolleci", actResult);
        }

        [Test]
        public void CheckSitePeterburg()
        {
            driver.Url = Urls.mainPage;
            IWebElement peterburgButton = driver.FindElement(By.XPath(pageModel.sitePeterburgCoursesXPath));
            peterburgButton.Click();
            IWebElement coursePeterburgCheck = driver.FindElement(By.XPath(sitePeterburgCourses.sitePeterburgCoursXPath));
            string actResult = coursePeterburgCheck.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckSiteKyiv()
        {
            driver.Url = Urls.mainPage;
            IWebElement kyivButton = driver.FindElement(By.XPath(pageModel.siteKyivCoursesXPath));
            kyivButton.Click();
            IWebElement courseKyivCheck = driver.FindElement(By.XPath(siteKyivCourses.siteKyivCoursXPath));
            string actResult = courseKyivCheck.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckSiteDnepr()
        {
            driver.Url = Urls.mainPage;
            IWebElement dneprButton = driver.FindElement(By.XPath(pageModel.siteDneprCoursesXPath));
            dneprButton.Click();
            IWebElement courseDneprCheck = driver.FindElement(By.XPath(siteDneprCourses.siteDneprCoursXPath));
            string actResult = courseDneprCheck.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckSiteKharkov()
        {
            driver.Url = Urls.mainPage;
            IWebElement kharkovButton = driver.FindElement(By.XPath(pageModel.siteKharkovCoursesXPath));
            kharkovButton.Click();
            IWebElement courseKharkovCheck = driver.FindElement(By.XPath(siteKharkovCourses.siteKharkovCoursXPath));
            string actResult = courseKharkovCheck.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckSiteBaku()
        {
            driver.Url = Urls.mainPage;
            IWebElement bakuButton = driver.FindElement(By.XPath(pageModel.siteBakuCoursesXPath));
            bakuButton.Click();
            IWebElement courseBakuCheck = driver.FindElement(By.XPath(siteBakuCourses.siteBakuCoursXPath));
            string actResult = courseBakuCheck.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckArticleNews()
        {
            driver.Url = Urls.mainPage;
            IWebElement newsButton = driver.FindElement(By.XPath(pageModel.newsMenuButtonXPath));
            newsButton.Click();
            IWebElement articleButton = driver.FindElement(By.XPath(pageModel.articleNewsButtonXPath));
            articleButton.Click();
            IWebElement articlePage = driver.FindElement(By.TagName(articleNewsPage.ourArticleNews));
            string actResult = articlePage.Text;
            Assert.AreEqual("В Баку выпускников пригласили в крупные IT-компании", actResult);
        }
    }
}
