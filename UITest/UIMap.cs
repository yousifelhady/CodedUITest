namespace UITest
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// TestMenu1SubMenu11_Assertion - Use 'TestMenu1SubMenu11_AssertionExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TestMenu1SubMenu11_Assertion()
        {
            #region Variable Declarations
            WinTitleBar uIMenu11TitleBar = this.UIMenu11Window.UIMenu11TitleBar;
            WinText uIHelloFromSubMenu11Text = this.UIMenu11Window.UIHelloFromSubMenu11Window.UIHelloFromSubMenu11Text;
            #endregion

            // Verify that the 'DisplayText' property of 'Menu1.1' title bar equals 'Menu1.1'
            Assert.AreEqual(this.TestMenu1SubMenu11_AssertionExpectedValues.UIMenu11TitleBarDisplayText, uIMenu11TitleBar.DisplayText);

            // Verify that the 'DisplayText' property of 'Hello From SubMenu1.1' label equals 'Hello From SubMenu1.1'
            Assert.AreEqual(this.TestMenu1SubMenu11_AssertionExpectedValues.UIHelloFromSubMenu11TextDisplayText, uIHelloFromSubMenu11Text.DisplayText);
        }

        public virtual TestMenu1SubMenu11_AssertionExpectedValues TestMenu1SubMenu11_AssertionExpectedValues
        {
            get
            {
                if ((this.mTestMenu1SubMenu11_AssertionExpectedValues == null))
                {
                    this.mTestMenu1SubMenu11_AssertionExpectedValues = new TestMenu1SubMenu11_AssertionExpectedValues();
                }
                return this.mTestMenu1SubMenu11_AssertionExpectedValues;
            }
        }

        private TestMenu1SubMenu11_AssertionExpectedValues mTestMenu1SubMenu11_AssertionExpectedValues;

        /// <summary>
        /// TestMenu1SubMenu11 - Use 'TestMenu1SubMenu11Params' to pass parameters into this method.
        /// </summary>
        public void TestMenu1SubMenu11()
        {
            #region Variable Declarations
            WinMenuItem uISubMenu11MenuItem = this.UIWindowsAppTestWindow.UIMenuStrip2MenuBar.UIMenu1MenuItem.UISubMenu11MenuItem;
            #endregion

            // Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
            ApplicationUnderTest uIWindowsAppTestWindow = ApplicationUnderTest.Launch(this.TestMenu1SubMenu11Params.UIWindowsAppTestWindowExePath, this.TestMenu1SubMenu11Params.UIWindowsAppTestWindowAlternateExePath);
            uISubMenu11MenuItem.DrawHighlight();
            // Click 'Menu1' -> 'SubMenu1.1' menu item
            Mouse.Click(uISubMenu11MenuItem, new Point(89, 16));
        }

        public virtual TestMenu1SubMenu11Params TestMenu1SubMenu11Params
        {
            get
            {
                if ((this.mTestMenu1SubMenu11Params == null))
                {
                    this.mTestMenu1SubMenu11Params = new TestMenu1SubMenu11Params();
                }
                return this.mTestMenu1SubMenu11Params;
            }
        }

        private TestMenu1SubMenu11Params mTestMenu1SubMenu11Params;

        /// <summary>
        /// TestMenu2SubMenu21_Assertion - Use 'TestMenu2SubMenu21_AssertionExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu21_Assertion()
        {
            #region Variable Declarations
            WinTitleBar uIMenu21TitleBar = this.UIMenu21Window.UIMenu21TitleBar;
            WinText uIHelloFromSubMenu21Text = this.UIMenu21Window.UIHelloFromSubMenu21Window.UIHelloFromSubMenu21Text;
            #endregion

            // Verify that the 'DisplayText' property of 'Menu2.1' title bar equals 'Menu2.1'
            Assert.AreEqual(this.TestMenu2SubMenu21_AssertionExpectedValues.UIMenu21TitleBarDisplayText, uIMenu21TitleBar.DisplayText);

            // Verify that the 'DisplayText' property of 'Hello From SubMenu2.1' label equals 'Hello From SubMenu2.1'
            Assert.AreEqual(this.TestMenu2SubMenu21_AssertionExpectedValues.UIHelloFromSubMenu21TextDisplayText, uIHelloFromSubMenu21Text.DisplayText);
        }

        public virtual TestMenu2SubMenu21_AssertionExpectedValues TestMenu2SubMenu21_AssertionExpectedValues
        {
            get
            {
                if ((this.mTestMenu2SubMenu21_AssertionExpectedValues == null))
                {
                    this.mTestMenu2SubMenu21_AssertionExpectedValues = new TestMenu2SubMenu21_AssertionExpectedValues();
                }
                return this.mTestMenu2SubMenu21_AssertionExpectedValues;
            }
        }

        private TestMenu2SubMenu21_AssertionExpectedValues mTestMenu2SubMenu21_AssertionExpectedValues;

        /// <summary>
        /// TestMenu2SubMenu31_Assertion - Use 'TestMenu2SubMenu31_AssertionExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu31_Assertion()
        {
            #region Variable Declarations
            WinTitleBar uIMenu31TitleBar = this.UIMenu31Window.UIMenu31TitleBar;
            WinText uIHelloFromSubMenu31Text = this.UIMenu31Window.UIHelloFromSubMenu31Window.UIHelloFromSubMenu31Text;
            #endregion

            // Verify that the 'DisplayText' property of 'Menu3.1' title bar equals 'Menu3.1'
            Assert.AreEqual(this.TestMenu2SubMenu31_AssertionExpectedValues.UIMenu31TitleBarDisplayText, uIMenu31TitleBar.DisplayText);

            // Verify that the 'DisplayText' property of 'Hello From SubMenu3.1' label equals 'Hello From SubMenu3.1'
            Assert.AreEqual(this.TestMenu2SubMenu31_AssertionExpectedValues.UIHelloFromSubMenu31TextDisplayText, uIHelloFromSubMenu31Text.DisplayText);
        }

        public virtual TestMenu2SubMenu31_AssertionExpectedValues TestMenu2SubMenu31_AssertionExpectedValues
        {
            get
            {
                if ((this.mTestMenu2SubMenu31_AssertionExpectedValues == null))
                {
                    this.mTestMenu2SubMenu31_AssertionExpectedValues = new TestMenu2SubMenu31_AssertionExpectedValues();
                }
                return this.mTestMenu2SubMenu31_AssertionExpectedValues;
            }
        }

        private TestMenu2SubMenu31_AssertionExpectedValues mTestMenu2SubMenu31_AssertionExpectedValues;

        /// <summary>
        /// TestMenu2SubMenu41_Assertion - Use 'TestMenu2SubMenu41_AssertionExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu41_Assertion()
        {
            #region Variable Declarations
            WinTitleBar uIMenu41TitleBar = this.UIMenu41Window.UIMenu41TitleBar;
            WinText uIHelloFromSubMenu41Text = this.UIMenu41Window.UIHelloFromSubMenu41Window.UIHelloFromSubMenu41Text;
            #endregion

            // Verify that the 'DisplayText' property of 'Menu4.1' title bar equals 'Menu4.1'
            Assert.AreEqual(this.TestMenu2SubMenu41_AssertionExpectedValues.UIMenu41TitleBarDisplayText, uIMenu41TitleBar.DisplayText);

            // Verify that the 'DisplayText' property of 'Hello From SubMenu4.1' label equals 'Hello From SubMenu4.1'
            Assert.AreEqual(this.TestMenu2SubMenu41_AssertionExpectedValues.UIHelloFromSubMenu41TextDisplayText, uIHelloFromSubMenu41Text.DisplayText);
        }

        public virtual TestMenu2SubMenu41_AssertionExpectedValues TestMenu2SubMenu41_AssertionExpectedValues
        {
            get
            {
                if ((this.mTestMenu2SubMenu41_AssertionExpectedValues == null))
                {
                    this.mTestMenu2SubMenu41_AssertionExpectedValues = new TestMenu2SubMenu41_AssertionExpectedValues();
                }
                return this.mTestMenu2SubMenu41_AssertionExpectedValues;
            }
        }

        private TestMenu2SubMenu41_AssertionExpectedValues mTestMenu2SubMenu41_AssertionExpectedValues;

        /// <summary>
        /// TestMenu2SubMenu41 - Use 'TestMenu2SubMenu41Params' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu41()
        {
            #region Variable Declarations
            WinMenuItem uISubMenu41MenuItem = this.UIWindowsAppTestWindow.UIMenuStrip2MenuBar.UIMenu4MenuItem.UISubMenu41MenuItem;
            #endregion

            // Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
            ApplicationUnderTest uIWindowsAppTestWindow = ApplicationUnderTest.Launch(this.TestMenu2SubMenu41Params.UIWindowsAppTestWindowExePath, this.TestMenu2SubMenu41Params.UIWindowsAppTestWindowAlternateExePath);
            uISubMenu41MenuItem.DrawHighlight();
            // Click 'Menu4' -> 'SubMenu4.1' menu item
            Mouse.Click(uISubMenu41MenuItem, new Point(53, 16));
        }

        public virtual TestMenu2SubMenu41Params TestMenu2SubMenu41Params
        {
            get
            {
                if ((this.mTestMenu2SubMenu41Params == null))
                {
                    this.mTestMenu2SubMenu41Params = new TestMenu2SubMenu41Params();
                }
                return this.mTestMenu2SubMenu41Params;
            }
        }

        private TestMenu2SubMenu41Params mTestMenu2SubMenu41Params;

        /// <summary>
        /// TestMenu2SubMenu31 - Use 'TestMenu2SubMenu31Params' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu31()
        {
            #region Variable Declarations
            WinMenuItem uISubMenu31MenuItem = this.UIWindowsAppTestWindow.UIMenuStrip2MenuBar.UIMenu3MenuItem.UISubMenu31MenuItem;
            #endregion

            // Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
            ApplicationUnderTest uIWindowsAppTestWindow = ApplicationUnderTest.Launch(this.TestMenu2SubMenu31Params.UIWindowsAppTestWindowExePath, this.TestMenu2SubMenu31Params.UIWindowsAppTestWindowAlternateExePath);
            uISubMenu31MenuItem.DrawHighlight();
            // Click 'Menu3' -> 'SubMenu3.1' menu item
            Mouse.Click(uISubMenu31MenuItem, new Point(42, 15));
        }

        public virtual TestMenu2SubMenu31Params TestMenu2SubMenu31Params
        {
            get
            {
                if ((this.mTestMenu2SubMenu31Params == null))
                {
                    this.mTestMenu2SubMenu31Params = new TestMenu2SubMenu31Params();
                }
                return this.mTestMenu2SubMenu31Params;
            }
        }

        private TestMenu2SubMenu31Params mTestMenu2SubMenu31Params;

        /// <summary>
        /// TestMenu2SubMenu21 - Use 'TestMenu2SubMenu21Params' to pass parameters into this method.
        /// </summary>
        public void TestMenu2SubMenu21()
        {
            #region Variable Declarations
            WinMenuItem uISubMenu21MenuItem = this.UIWindowsAppTestWindow.UIMenuStrip2MenuBar.UIMenu2MenuItem.UISubMenu21MenuItem;
            #endregion

            // Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
            ApplicationUnderTest uIWindowsAppTestWindow = ApplicationUnderTest.Launch(this.TestMenu2SubMenu21Params.UIWindowsAppTestWindowExePath, this.TestMenu2SubMenu21Params.UIWindowsAppTestWindowAlternateExePath);
            uISubMenu21MenuItem.DrawHighlight();
            // Click 'Menu2' -> 'SubMenu2.1' menu item
            Mouse.Click(uISubMenu21MenuItem, new Point(93, 16));
        }

        public virtual TestMenu2SubMenu21Params TestMenu2SubMenu21Params
        {
            get
            {
                if ((this.mTestMenu2SubMenu21Params == null))
                {
                    this.mTestMenu2SubMenu21Params = new TestMenu2SubMenu21Params();
                }
                return this.mTestMenu2SubMenu21Params;
            }
        }

        private TestMenu2SubMenu21Params mTestMenu2SubMenu21Params;
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu1SubMenu11_Assertion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu1SubMenu11_AssertionExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Menu1.1' title bar equals 'Menu1.1'
        /// </summary>
        public string UIMenu11TitleBarDisplayText = "Menu1.1";

        /// <summary>
        /// Verify that the 'DisplayText' property of 'Hello From SubMenu1.1' label equals 'Hello From SubMenu1.1'
        /// </summary>
        public string UIHelloFromSubMenu11TextDisplayText = "Hello From SubMenu1.1";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu1SubMenu11'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu1SubMenu11Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowExePath = AutoLoader.PrepareLoader(Type.launchTestGUIApp).AppExePath;

        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowAlternateExePath = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu21_Assertion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu21_AssertionExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Menu2.1' title bar equals 'Menu2.1'
        /// </summary>
        public string UIMenu21TitleBarDisplayText = "Menu2.1";

        /// <summary>
        /// Verify that the 'DisplayText' property of 'Hello From SubMenu2.1' label equals 'Hello From SubMenu2.1'
        /// </summary>
        public string UIHelloFromSubMenu21TextDisplayText = "Hello From SubMenu2.1";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu31_Assertion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu31_AssertionExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Menu3.1' title bar equals 'Menu3.1'
        /// </summary>
        public string UIMenu31TitleBarDisplayText = "Menu3.1";

        /// <summary>
        /// Verify that the 'DisplayText' property of 'Hello From SubMenu3.1' label equals 'Hello From SubMenu3.1'
        /// </summary>
        public string UIHelloFromSubMenu31TextDisplayText = "Hello From SubMenu3.1";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu41_Assertion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu41_AssertionExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Menu4.1' title bar equals 'Menu4.1'
        /// </summary>
        public string UIMenu41TitleBarDisplayText = "Menu4.1";

        /// <summary>
        /// Verify that the 'DisplayText' property of 'Hello From SubMenu4.1' label equals 'Hello From SubMenu4.1'
        /// </summary>
        public string UIHelloFromSubMenu41TextDisplayText = "Hello From SubMenu4.1";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu41'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu41Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowExePath = AutoLoader.PrepareLoader(Type.launchTestGUIApp).AppExePath;

        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowAlternateExePath = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu31'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu31Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowExePath = AutoLoader.PrepareLoader(Type.launchTestGUIApp).AppExePath;

        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowAlternateExePath = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'TestMenu2SubMenu21'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TestMenu2SubMenu21Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowExePath = AutoLoader.PrepareLoader(Type.launchTestGUIApp).AppExePath;

        /// <summary>
        /// Launch '%USERPROFILE%\Downloads\_Projects\TestGUI\TestGUI\bin\Debug\TestGUI.exe'
        /// </summary>
        public string UIWindowsAppTestWindowAlternateExePath = "";
        #endregion
    }
}
