﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        #region Properties
        public UIWindowsAppTestWindow UIWindowsAppTestWindow
        {
            get
            {
                if ((this.mUIWindowsAppTestWindow == null))
                {
                    this.mUIWindowsAppTestWindow = new UIWindowsAppTestWindow();
                }
                return this.mUIWindowsAppTestWindow;
            }
        }
        
        public UIMenu11Window UIMenu11Window
        {
            get
            {
                if ((this.mUIMenu11Window == null))
                {
                    this.mUIMenu11Window = new UIMenu11Window();
                }
                return this.mUIMenu11Window;
            }
        }
        
        public UIMenu21Window UIMenu21Window
        {
            get
            {
                if ((this.mUIMenu21Window == null))
                {
                    this.mUIMenu21Window = new UIMenu21Window();
                }
                return this.mUIMenu21Window;
            }
        }
        
        public UIMenu31Window UIMenu31Window
        {
            get
            {
                if ((this.mUIMenu31Window == null))
                {
                    this.mUIMenu31Window = new UIMenu31Window();
                }
                return this.mUIMenu31Window;
            }
        }
        
        public UIMenu41Window UIMenu41Window
        {
            get
            {
                if ((this.mUIMenu41Window == null))
                {
                    this.mUIMenu41Window = new UIMenu41Window();
                }
                return this.mUIMenu41Window;
            }
        }
        #endregion
        
        #region Fields
        private UIWindowsAppTestWindow mUIWindowsAppTestWindow;
        
        private UIMenu11Window mUIMenu11Window;
        
        private UIMenu21Window mUIMenu21Window;
        
        private UIMenu31Window mUIMenu31Window;
        
        private UIMenu41Window mUIMenu41Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIWindowsAppTestWindow : WinWindow
    {
        
        public UIWindowsAppTestWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "WindowsAppTest";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public UIMenuStrip2MenuBar UIMenuStrip2MenuBar
        {
            get
            {
                if ((this.mUIMenuStrip2MenuBar == null))
                {
                    this.mUIMenuStrip2MenuBar = new UIMenuStrip2MenuBar(this);
                }
                return this.mUIMenuStrip2MenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuStrip2MenuBar mUIMenuStrip2MenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenuStrip2MenuBar : WinMenuBar
    {
        
        public UIMenuStrip2MenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip2";
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public UIMenu1MenuItem UIMenu1MenuItem
        {
            get
            {
                if ((this.mUIMenu1MenuItem == null))
                {
                    this.mUIMenu1MenuItem = new UIMenu1MenuItem(this);
                }
                return this.mUIMenu1MenuItem;
            }
        }
        
        public UIMenu2MenuItem UIMenu2MenuItem
        {
            get
            {
                if ((this.mUIMenu2MenuItem == null))
                {
                    this.mUIMenu2MenuItem = new UIMenu2MenuItem(this);
                }
                return this.mUIMenu2MenuItem;
            }
        }
        
        public UIMenu3MenuItem UIMenu3MenuItem
        {
            get
            {
                if ((this.mUIMenu3MenuItem == null))
                {
                    this.mUIMenu3MenuItem = new UIMenu3MenuItem(this);
                }
                return this.mUIMenu3MenuItem;
            }
        }
        
        public UIMenu4MenuItem UIMenu4MenuItem
        {
            get
            {
                if ((this.mUIMenu4MenuItem == null))
                {
                    this.mUIMenu4MenuItem = new UIMenu4MenuItem(this);
                }
                return this.mUIMenu4MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIMenu1MenuItem mUIMenu1MenuItem;
        
        private UIMenu2MenuItem mUIMenu2MenuItem;
        
        private UIMenu3MenuItem mUIMenu3MenuItem;
        
        private UIMenu4MenuItem mUIMenu4MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu1MenuItem : WinMenuItem
    {
        
        public UIMenu1MenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Menu1";
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UISubMenu11MenuItem
        {
            get
            {
                if ((this.mUISubMenu11MenuItem == null))
                {
                    this.mUISubMenu11MenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISubMenu11MenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "SubMenu1.1";
                    this.mUISubMenu11MenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUISubMenu11MenuItem.WindowTitles.Add("WindowsAppTest");
                    #endregion
                }
                return this.mUISubMenu11MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUISubMenu11MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu2MenuItem : WinMenuItem
    {
        
        public UIMenu2MenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Menu2";
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UISubMenu21MenuItem
        {
            get
            {
                if ((this.mUISubMenu21MenuItem == null))
                {
                    this.mUISubMenu21MenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISubMenu21MenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "SubMenu2.1";
                    this.mUISubMenu21MenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUISubMenu21MenuItem.WindowTitles.Add("WindowsAppTest");
                    #endregion
                }
                return this.mUISubMenu21MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUISubMenu21MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu3MenuItem : WinMenuItem
    {
        
        public UIMenu3MenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Menu3";
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UISubMenu31MenuItem
        {
            get
            {
                if ((this.mUISubMenu31MenuItem == null))
                {
                    this.mUISubMenu31MenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISubMenu31MenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "SubMenu3.1";
                    this.mUISubMenu31MenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUISubMenu31MenuItem.WindowTitles.Add("WindowsAppTest");
                    #endregion
                }
                return this.mUISubMenu31MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUISubMenu31MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu4MenuItem : WinMenuItem
    {
        
        public UIMenu4MenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Menu4";
            this.WindowTitles.Add("WindowsAppTest");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UISubMenu41MenuItem
        {
            get
            {
                if ((this.mUISubMenu41MenuItem == null))
                {
                    this.mUISubMenu41MenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISubMenu41MenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "SubMenu4.1";
                    this.mUISubMenu41MenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUISubMenu41MenuItem.WindowTitles.Add("WindowsAppTest");
                    #endregion
                }
                return this.mUISubMenu41MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUISubMenu41MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu11Window : WinWindow
    {
        
        public UIMenu11Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Menu1.1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Menu1.1");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMenu11TitleBar
        {
            get
            {
                if ((this.mUIMenu11TitleBar == null))
                {
                    this.mUIMenu11TitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMenu11TitleBar.WindowTitles.Add("Menu1.1");
                    #endregion
                }
                return this.mUIMenu11TitleBar;
            }
        }
        
        public UIHelloFromSubMenu11Window UIHelloFromSubMenu11Window
        {
            get
            {
                if ((this.mUIHelloFromSubMenu11Window == null))
                {
                    this.mUIHelloFromSubMenu11Window = new UIHelloFromSubMenu11Window(this);
                }
                return this.mUIHelloFromSubMenu11Window;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMenu11TitleBar;
        
        private UIHelloFromSubMenu11Window mUIHelloFromSubMenu11Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHelloFromSubMenu11Window : WinWindow
    {
        
        public UIHelloFromSubMenu11Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("Menu1.1");
            #endregion
        }
        
        #region Properties
        public WinText UIHelloFromSubMenu11Text
        {
            get
            {
                if ((this.mUIHelloFromSubMenu11Text == null))
                {
                    this.mUIHelloFromSubMenu11Text = new WinText(this);
                    #region Search Criteria
                    this.mUIHelloFromSubMenu11Text.SearchProperties[WinText.PropertyNames.Name] = "Hello From SubMenu1.1";
                    this.mUIHelloFromSubMenu11Text.WindowTitles.Add("Menu1.1");
                    #endregion
                }
                return this.mUIHelloFromSubMenu11Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHelloFromSubMenu11Text;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu21Window : WinWindow
    {
        
        public UIMenu21Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Menu2.1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Menu2.1");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMenu21TitleBar
        {
            get
            {
                if ((this.mUIMenu21TitleBar == null))
                {
                    this.mUIMenu21TitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMenu21TitleBar.WindowTitles.Add("Menu2.1");
                    #endregion
                }
                return this.mUIMenu21TitleBar;
            }
        }
        
        public UIHelloFromSubMenu21Window UIHelloFromSubMenu21Window
        {
            get
            {
                if ((this.mUIHelloFromSubMenu21Window == null))
                {
                    this.mUIHelloFromSubMenu21Window = new UIHelloFromSubMenu21Window(this);
                }
                return this.mUIHelloFromSubMenu21Window;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMenu21TitleBar;
        
        private UIHelloFromSubMenu21Window mUIHelloFromSubMenu21Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHelloFromSubMenu21Window : WinWindow
    {
        
        public UIHelloFromSubMenu21Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("Menu2.1");
            #endregion
        }
        
        #region Properties
        public WinText UIHelloFromSubMenu21Text
        {
            get
            {
                if ((this.mUIHelloFromSubMenu21Text == null))
                {
                    this.mUIHelloFromSubMenu21Text = new WinText(this);
                    #region Search Criteria
                    this.mUIHelloFromSubMenu21Text.SearchProperties[WinText.PropertyNames.Name] = "Hello From SubMenu2.1";
                    this.mUIHelloFromSubMenu21Text.WindowTitles.Add("Menu2.1");
                    #endregion
                }
                return this.mUIHelloFromSubMenu21Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHelloFromSubMenu21Text;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu31Window : WinWindow
    {
        
        public UIMenu31Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Menu3.1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Menu3.1");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMenu31TitleBar
        {
            get
            {
                if ((this.mUIMenu31TitleBar == null))
                {
                    this.mUIMenu31TitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMenu31TitleBar.WindowTitles.Add("Menu3.1");
                    #endregion
                }
                return this.mUIMenu31TitleBar;
            }
        }
        
        public UIHelloFromSubMenu31Window UIHelloFromSubMenu31Window
        {
            get
            {
                if ((this.mUIHelloFromSubMenu31Window == null))
                {
                    this.mUIHelloFromSubMenu31Window = new UIHelloFromSubMenu31Window(this);
                }
                return this.mUIHelloFromSubMenu31Window;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMenu31TitleBar;
        
        private UIHelloFromSubMenu31Window mUIHelloFromSubMenu31Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHelloFromSubMenu31Window : WinWindow
    {
        
        public UIHelloFromSubMenu31Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("Menu3.1");
            #endregion
        }
        
        #region Properties
        public WinText UIHelloFromSubMenu31Text
        {
            get
            {
                if ((this.mUIHelloFromSubMenu31Text == null))
                {
                    this.mUIHelloFromSubMenu31Text = new WinText(this);
                    #region Search Criteria
                    this.mUIHelloFromSubMenu31Text.SearchProperties[WinText.PropertyNames.Name] = "Hello From SubMenu3.1";
                    this.mUIHelloFromSubMenu31Text.WindowTitles.Add("Menu3.1");
                    #endregion
                }
                return this.mUIHelloFromSubMenu31Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHelloFromSubMenu31Text;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenu41Window : WinWindow
    {
        
        public UIMenu41Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Menu4.1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Menu4.1");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMenu41TitleBar
        {
            get
            {
                if ((this.mUIMenu41TitleBar == null))
                {
                    this.mUIMenu41TitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMenu41TitleBar.WindowTitles.Add("Menu4.1");
                    #endregion
                }
                return this.mUIMenu41TitleBar;
            }
        }
        
        public UIHelloFromSubMenu41Window UIHelloFromSubMenu41Window
        {
            get
            {
                if ((this.mUIHelloFromSubMenu41Window == null))
                {
                    this.mUIHelloFromSubMenu41Window = new UIHelloFromSubMenu41Window(this);
                }
                return this.mUIHelloFromSubMenu41Window;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMenu41TitleBar;
        
        private UIHelloFromSubMenu41Window mUIHelloFromSubMenu41Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHelloFromSubMenu41Window : WinWindow
    {
        
        public UIHelloFromSubMenu41Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("Menu4.1");
            #endregion
        }
        
        #region Properties
        public WinText UIHelloFromSubMenu41Text
        {
            get
            {
                if ((this.mUIHelloFromSubMenu41Text == null))
                {
                    this.mUIHelloFromSubMenu41Text = new WinText(this);
                    #region Search Criteria
                    this.mUIHelloFromSubMenu41Text.SearchProperties[WinText.PropertyNames.Name] = "Hello From SubMenu4.1";
                    this.mUIHelloFromSubMenu41Text.WindowTitles.Add("Menu4.1");
                    #endregion
                }
                return this.mUIHelloFromSubMenu41Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHelloFromSubMenu41Text;
        #endregion
    }
}
