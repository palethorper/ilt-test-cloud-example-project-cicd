using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ApplicationTestingILT.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome__UiBank_Loan_Apply_app
        {
            static string _reference = "GtvnX6OfOUCtv3dQPEjiDg/XOCBI8Ti_EWVvctTO-FdLA";
            public static _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome_UiBank_Loan_result Chrome_UiBank_Loan_result { get; private set; } = new _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome_UiBank_Loan_result();
            public static _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome__UiBank_Loan_Apply Chrome__UiBank_Loan_Apply { get; private set; } = new _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome__UiBank_Loan_Apply();
            public static _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome__UiBank_Welcome Chrome__UiBank_Welcome { get; private set; } = new _Implementation._Chrome__UiBank_Loan_Apply_app.__Chrome__UiBank_Welcome();
        }

        public static class UiBank
        {
            static string _reference = "GtvnX6OfOUCtv3dQPEjiDg/CaolpzH4g0S1uKaWHd520Q";
            public static _Implementation._UiBank.__Accounts Accounts { get; private set; } = new _Implementation._UiBank.__Accounts();
            public static _Implementation._UiBank.__Login Login { get; private set; } = new _Implementation._UiBank.__Login();
        }
    }
}

namespace ApplicationTestingILT._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Apply_For_Another_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_Another_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/BAWKmdgcAEOCp87blj-Azw",
                    DisplayName = "Apply For Another Loan",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Back_To_Loan_Center : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Back_To_Loan_Center(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/WJpHZF3mX0WW4P_upT18RA",
                    DisplayName = "Back To Loan Center",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Congrats_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Congrats_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/M3NI6_ARWk63SOKcIhbJtg",
                    DisplayName = "Congrats!",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Loan_ID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_ID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/cM-8gBEZ60y-lM_6DCLfaQ",
                    DisplayName = "Loan ID",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Loan_Rate_Text : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Rate_Text(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/DH94-0i6NE2tP0jFWWqQnQ",
                    DisplayName = "Loan Rate Text",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Login : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Login(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/nu_NPDaSf0m94KG-aoZXPQ",
                    DisplayName = "Login",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __Need_a_Loan_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Need_a_Loan_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/k4o5NMX-f0KmstzHXL_FQQ",
                    DisplayName = "Need a Loan?",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __rate_type : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __rate_type(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/FQ5aeyD1NECWbbdjZtRAkw",
                    DisplayName = "rate type",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result
    {
        public class __You_ve_been_approved_fo_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __You_ve_been_approved_fo_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/ElC8bQHPxEiwHQ2uO5wxlg",
                    DisplayName = "You've been approved fo…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app
    {
        public class __Chrome_UiBank_Loan_result : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_UiBank_Loan_result()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/Tb04hKQCpUyFVokjgZXwfw",
                    DisplayName = "Chrome UiBank-Loan result",
                    Screen = this
                };
                Apply_For_Another_Loan = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Apply_For_Another_Loan(this, null);
                Back_To_Loan_Center = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Back_To_Loan_Center(this, null);
                Congrats_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Congrats_(this, null);
                Loan_ID = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Loan_ID(this, null);
                Loan_Rate_Text = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Loan_Rate_Text(this, null);
                Login = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Login(this, null);
                Need_a_Loan_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Need_a_Loan_(this, null);
                rate_type = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__rate_type(this, null);
                You_ve_been_approved_fo_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__You_ve_been_approved_fo_(this, null);
            }

            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Apply_For_Another_Loan Apply_For_Another_Loan { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Back_To_Loan_Center Back_To_Loan_Center { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Congrats_ Congrats_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Loan_ID Loan_ID { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Loan_Rate_Text Loan_Rate_Text { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Login Login { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__Need_a_Loan_ Need_a_Loan_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__rate_type rate_type { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome_UiBank_Loan_result.__You_ve_been_approved_fo_ You_ve_been_approved_fo_ { get; private set; }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class ____Back : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ____Back(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/UT-17E5sNUO2Y9ncK0Dv_g",
                    DisplayName = "< Back",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/h8f8ipQagEG-nF6HxPvKSA",
                    DisplayName = "Age",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Current_Yearly_Income___ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Current_Yearly_Income___(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/widCQSSRPEGRXeFaB0437w",
                    DisplayName = "Current Yearly Income (…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Email_Address_of_Reques_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email_Address_of_Reques_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/cIG3Ca7w9kysetF-dBeGkQ",
                    DisplayName = "Email Address of Reques…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Loan_Amount_Requested : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount_Requested(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/z9QnjrqGLU-mZi6d5mkD1g",
                    DisplayName = "Loan Amount Requested",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Loan_Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/T6MbGDnfFUGpl4SCUJrFhA",
                    DisplayName = "Loan Term",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply
    {
        public class __Submit_Loan_Application : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Loan_Application(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/nnt3xfmEAkWo5XiBrjmkvA",
                    DisplayName = "Submit Loan Application",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app
    {
        public class __Chrome__UiBank_Loan_Apply : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome__UiBank_Loan_Apply()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/O8y_-ew220CgopGL20fcbA",
                    DisplayName = "Chrome: UiBank-Loan Apply",
                    Screen = this
                };
                __Back = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.____Back(this, null);
                Age = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Age(this, null);
                Current_Yearly_Income___ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Current_Yearly_Income___(this, null);
                Email_Address_of_Reques_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Email_Address_of_Reques_(this, null);
                Loan_Amount_Requested = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Loan_Amount_Requested(this, null);
                Loan_Term = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Loan_Term(this, null);
                Submit_Loan_Application = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Submit_Loan_Application(this, null);
            }

            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.____Back __Back { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Age Age { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Current_Yearly_Income___ Current_Yearly_Income___ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Email_Address_of_Reques_ Email_Address_of_Reques_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Loan_Amount_Requested Loan_Amount_Requested { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Loan_Term Loan_Term { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Loan_Apply.__Submit_Loan_Application Submit_Loan_Application { get; private set; }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __A__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __A__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/PX9pHtjYY0SJgOfetLQakg",
                    DisplayName = "A /",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __A__home : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __A__home(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/2w3aQWRDF0i0FsaGvqNhlg",
                    DisplayName = "A /home",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Apply_For_Account__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_Account__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/Q1CdelEYDEm6dFeFDPIttQ",
                    DisplayName = "Apply For Account →",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Apply_For_Loan__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_Loan__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/dwwmvqRqTkiarjSm3nH5JA",
                    DisplayName = "Apply For Loan →",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Contact_Us : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Contact_Us(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/bceqx995yE-CAMfMmWo_dw",
                    DisplayName = "Contact Us",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Forgot_Your_Password_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Forgot_Your_Password_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/F6z8ssowf02mfWeN9nENBQ",
                    DisplayName = "Forgot Your Password?",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Get_Started__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Get_Started__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/h8_Mo8kyUkObuccZ97EObw",
                    DisplayName = "Get Started →",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __IMG : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __IMG(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/yUPu5A4S0EKeiai30ik8JQ",
                    DisplayName = "IMG",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __IMG_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __IMG_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/a5ymYag6b0SGwXAS-CqbhQ",
                    DisplayName = "IMG(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __IMG_2_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __IMG_2_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/r9vSfkc10kiQjl63X8Lofg",
                    DisplayName = "IMG(2)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __IMG_3_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __IMG_3_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/JyTqQdGZpkmvs4TIE_XvTQ",
                    DisplayName = "IMG(3)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Learn_More__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Learn_More__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/qPBmnFLOnESvkum-JSGRWg",
                    DisplayName = "Learn More →",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Login : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Login(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/AYms2R1cFEKxNGNp9CM4uA",
                    DisplayName = "Login",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Need_a_Loan_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Need_a_Loan_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/yUxV4Avrp0a4MW3K99W7pQ",
                    DisplayName = "Need a Loan?",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/PUkNljofGkiRY-j6zfeWiw",
                    DisplayName = "Password",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Privacy_Policy : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Privacy_Policy(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/H56xn1rA9E-mACqN82shxQ",
                    DisplayName = "Privacy Policy",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Products : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Products(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/5fu03iVvwkmYdGqqerf6Sw",
                    DisplayName = "Products",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Register_For_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Register_For_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/3ZDPlxZ8NUK_udG3t0ULCQ",
                    DisplayName = "Register For Account",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Sign_In : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sign_In(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/KtdhkQRwA06Dy7VOOBXSwQ",
                    DisplayName = "Sign In",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/tMbbj82_nE22d_RPQV2pRw",
                    DisplayName = "Username",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome__UiBank_Loan_Apply_app
    {
        public class __Chrome__UiBank_Welcome : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome__UiBank_Welcome()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/NSvg5CObVUWNlcOLHiCdTA",
                    DisplayName = "Chrome: UiBank-Welcome",
                    Screen = this
                };
                A__ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__A__(this, null);
                A__home = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__A__home(this, null);
                Apply_For_Account__ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Apply_For_Account__(this, null);
                Apply_For_Loan__ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Apply_For_Loan__(this, null);
                Contact_Us = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Contact_Us(this, null);
                Forgot_Your_Password_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Forgot_Your_Password_(this, null);
                Get_Started__ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Get_Started__(this, null);
                IMG = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG(this, null);
                IMG_1_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_1_(this, null);
                IMG_2_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_2_(this, null);
                IMG_3_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_3_(this, null);
                Learn_More__ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Learn_More__(this, null);
                Login = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Login(this, null);
                Need_a_Loan_ = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Need_a_Loan_(this, null);
                Password = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Password(this, null);
                Privacy_Policy = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Privacy_Policy(this, null);
                Products = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Products(this, null);
                Register_For_Account = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Register_For_Account(this, null);
                Sign_In = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Sign_In(this, null);
                Username = new _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Username(this, null);
            }

            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__A__ A__ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__A__home A__home { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Apply_For_Account__ Apply_For_Account__ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Apply_For_Loan__ Apply_For_Loan__ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Contact_Us Contact_Us { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Forgot_Your_Password_ Forgot_Your_Password_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Get_Started__ Get_Started__ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG IMG { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_1_ IMG_1_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_2_ IMG_2_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__IMG_3_ IMG_3_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Learn_More__ Learn_More__ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Login Login { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Need_a_Loan_ Need_a_Loan_ { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Password Password { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Privacy_Policy Privacy_Policy { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Products Products { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Register_For_Account Register_For_Account { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Sign_In Sign_In { get; private set; }
            public _Implementation._Chrome__UiBank_Loan_Apply_app._Chrome__UiBank_Welcome.__Username Username { get; private set; }
        }
    }

    namespace _UiBank._Accounts
    {
        public class __Welcome_message : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Welcome_message(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/Q_IO3s7TdUuDZAArbx0JBw",
                    DisplayName = "Welcome message",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank
    {
        public class __Accounts : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Accounts()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/y_vN5D3pv0WaDjiQwmxEPQ",
                    DisplayName = "Accounts",
                    Screen = this
                };
                Welcome_message = new _Implementation._UiBank._Accounts.__Welcome_message(this, null);
            }

            public _Implementation._UiBank._Accounts.__Welcome_message Welcome_message { get; private set; }
        }
    }

    namespace _UiBank._Login
    {
        public class __Forgot_Your_Password_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Forgot_Your_Password_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/5yRtXmfFAUq0LnBp4d-IAQ",
                    DisplayName = "Forgot Your Password?",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank._Login
    {
        public class __Logout : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Logout(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/F8ZJ7L3950Cxh7nlDNF2Pg",
                    DisplayName = "Logout",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank._Login
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/7tVY_N3ODUimtJ3sAZ1h3w",
                    DisplayName = "Password",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank._Login
    {
        public class __Register_For_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Register_For_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/RvqTdE-tCEy4F8MJ9KnLng",
                    DisplayName = "Register For Account",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank._Login
    {
        public class __Sign_In : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sign_In(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/Oa-xuUkou0mPfaKid3Lt7Q",
                    DisplayName = "Sign In",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank._Login
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/8j7vwFtwzEySzbbemql8oA",
                    DisplayName = "Username",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _UiBank
    {
        public class __Login : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Login()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "GtvnX6OfOUCtv3dQPEjiDg/wntqyoJ4p0yXvt5339Akfg",
                    DisplayName = "Login",
                    Screen = this
                };
                Forgot_Your_Password_ = new _Implementation._UiBank._Login.__Forgot_Your_Password_(this, null);
                Logout = new _Implementation._UiBank._Login.__Logout(this, null);
                Password = new _Implementation._UiBank._Login.__Password(this, null);
                Register_For_Account = new _Implementation._UiBank._Login.__Register_For_Account(this, null);
                Sign_In = new _Implementation._UiBank._Login.__Sign_In(this, null);
                Username = new _Implementation._UiBank._Login.__Username(this, null);
            }

            public _Implementation._UiBank._Login.__Forgot_Your_Password_ Forgot_Your_Password_ { get; private set; }
            public _Implementation._UiBank._Login.__Logout Logout { get; private set; }
            public _Implementation._UiBank._Login.__Password Password { get; private set; }
            public _Implementation._UiBank._Login.__Register_For_Account Register_For_Account { get; private set; }
            public _Implementation._UiBank._Login.__Sign_In Sign_In { get; private set; }
            public _Implementation._UiBank._Login.__Username Username { get; private set; }
        }
    }
}