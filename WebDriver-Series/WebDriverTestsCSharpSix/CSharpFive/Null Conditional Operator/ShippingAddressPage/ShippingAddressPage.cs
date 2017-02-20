﻿// <copyright file="ShippingAddressPage.cs" company="Automate The Planet Ltd.">
// Copyright 2017 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverTestsCSharpSix.CSharpFive.NullConditionalOperator
{
    public partial class ShippingAddressPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://www.amazon.com/shippingPage";

        public ShippingAddressPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

       // some other actions

        private void FillAddressInfoInternal(ClientPurchaseInfo clientInfo)
        {
            this.Country.SelectByText(clientInfo.Country);
            this.FullName.SendKeys(clientInfo.FullName);
            this.Address.SendKeys(clientInfo.Address);
            this.City.SendKeys(clientInfo.City);
            this.Zip.SendKeys(clientInfo.Zip == null ? string.Empty : clientInfo.Zip);
            this.Phone.SendKeys(clientInfo.Phone == null ? string.Empty : clientInfo.Phone);
            this.Vat.SendKeys(clientInfo.Vat == null ? string.Empty : clientInfo.Vat);
        }
    }
}
