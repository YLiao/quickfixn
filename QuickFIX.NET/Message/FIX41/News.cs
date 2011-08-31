// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class News : Message
        {
            public const string MsgType = "B";

            public News() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("B"));
            }

            public News(
                    QuickFix.Fields.Headline aHeadline
                ) : this()
            {
                this.headline = aHeadline;
            }

            public QuickFix.Fields.OrigTime origTime
            { 
                get 
                {
                    QuickFix.Fields.OrigTime val = new QuickFix.Fields.OrigTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTime val) 
            { 
                this.origTime = val;
            }
            
            public QuickFix.Fields.OrigTime get(QuickFix.Fields.OrigTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTime val) 
            { 
                return isSetOrigTime();
            }
            
            public bool isSetOrigTime() 
            { 
                return isSetField(Tags.OrigTime);
            }
            public QuickFix.Fields.Urgency urgency
            { 
                get 
                {
                    QuickFix.Fields.Urgency val = new QuickFix.Fields.Urgency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Urgency val) 
            { 
                this.urgency = val;
            }
            
            public QuickFix.Fields.Urgency get(QuickFix.Fields.Urgency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Urgency val) 
            { 
                return isSetUrgency();
            }
            
            public bool isSetUrgency() 
            { 
                return isSetField(Tags.Urgency);
            }
            public QuickFix.Fields.Headline headline
            { 
                get 
                {
                    QuickFix.Fields.Headline val = new QuickFix.Fields.Headline();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Headline val) 
            { 
                this.headline = val;
            }
            
            public QuickFix.Fields.Headline get(QuickFix.Fields.Headline val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Headline val) 
            { 
                return isSetHeadline();
            }
            
            public bool isSetHeadline() 
            { 
                return isSetField(Tags.Headline);
            }
            public QuickFix.Fields.NoRelatedSym noRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRelatedSym val) 
            { 
                this.noRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym get(QuickFix.Fields.NoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return isSetNoRelatedSym();
            }
            
            public bool isSetNoRelatedSym() 
            { 
                return isSetField(Tags.NoRelatedSym);
            }
            public QuickFix.Fields.LinesOfText linesOfText
            { 
                get 
                {
                    QuickFix.Fields.LinesOfText val = new QuickFix.Fields.LinesOfText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LinesOfText val) 
            { 
                this.linesOfText = val;
            }
            
            public QuickFix.Fields.LinesOfText get(QuickFix.Fields.LinesOfText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LinesOfText val) 
            { 
                return isSetLinesOfText();
            }
            
            public bool isSetLinesOfText() 
            { 
                return isSetField(Tags.LinesOfText);
            }
            public QuickFix.Fields.URLLink uRLLink
            { 
                get 
                {
                    QuickFix.Fields.URLLink val = new QuickFix.Fields.URLLink();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.URLLink val) 
            { 
                this.uRLLink = val;
            }
            
            public QuickFix.Fields.URLLink get(QuickFix.Fields.URLLink val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.URLLink val) 
            { 
                return isSetURLLink();
            }
            
            public bool isSetURLLink() 
            { 
                return isSetField(Tags.URLLink);
            }
            public QuickFix.Fields.RawDataLength rawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawDataLength val) 
            { 
                this.rawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength get(QuickFix.Fields.RawDataLength val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawDataLength val) 
            { 
                return isSetRawDataLength();
            }
            
            public bool isSetRawDataLength() 
            { 
                return isSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData rawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawData val) 
            { 
                this.rawData = val;
            }
            
            public QuickFix.Fields.RawData get(QuickFix.Fields.RawData val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawData val) 
            { 
                return isSetRawData();
            }
            
            public bool isSetRawData() 
            { 
                return isSetField(Tags.RawData);
            }
            public class NoRelatedSym : Group
            {
                public NoRelatedSym() 
                  :base( Tags.NoRelatedSym, Tags.RelatdSym, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.SecurityExchange, Tags.Issuer, Tags.SecurityDesc, 0};
                            public QuickFix.Fields.RelatdSym relatdSym
                { 
                    get 
                    {
                        QuickFix.Fields.RelatdSym val = new QuickFix.Fields.RelatdSym();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RelatdSym val) 
                { 
                    this.relatdSym = val;
                }
                
                public QuickFix.Fields.RelatdSym get(QuickFix.Fields.RelatdSym val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RelatdSym val) 
                { 
                    return isSetRelatdSym();
                }
                
                public bool isSetRelatdSym() 
                { 
                    return isSetField(Tags.RelatdSym);
                }
                public QuickFix.Fields.SymbolSfx symbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SymbolSfx val) 
                { 
                    this.symbolSfx = val;
                }
                
                public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SymbolSfx val) 
                { 
                    return isSetSymbolSfx();
                }
                
                public bool isSetSymbolSfx() 
                { 
                    return isSetField(Tags.SymbolSfx);
                }
                public QuickFix.Fields.SecurityID securityID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityID val) 
                { 
                    this.securityID = val;
                }
                
                public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityID val) 
                { 
                    return isSetSecurityID();
                }
                
                public bool isSetSecurityID() 
                { 
                    return isSetField(Tags.SecurityID);
                }
                public QuickFix.Fields.IDSource iDSource
                { 
                    get 
                    {
                        QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.IDSource val) 
                { 
                    this.iDSource = val;
                }
                
                public QuickFix.Fields.IDSource get(QuickFix.Fields.IDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.IDSource val) 
                { 
                    return isSetIDSource();
                }
                
                public bool isSetIDSource() 
                { 
                    return isSetField(Tags.IDSource);
                }
                public QuickFix.Fields.SecurityType securityType
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityType val) 
                { 
                    this.securityType = val;
                }
                
                public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityType val) 
                { 
                    return isSetSecurityType();
                }
                
                public bool isSetSecurityType() 
                { 
                    return isSetField(Tags.SecurityType);
                }
                public QuickFix.Fields.MaturityMonthYear maturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    this.maturityMonthYear = val;
                }
                
                public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    return isSetMaturityMonthYear();
                }
                
                public bool isSetMaturityMonthYear() 
                { 
                    return isSetField(Tags.MaturityMonthYear);
                }
                public QuickFix.Fields.MaturityDay maturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityDay val) 
                { 
                    this.maturityDay = val;
                }
                
                public QuickFix.Fields.MaturityDay get(QuickFix.Fields.MaturityDay val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityDay val) 
                { 
                    return isSetMaturityDay();
                }
                
                public bool isSetMaturityDay() 
                { 
                    return isSetField(Tags.MaturityDay);
                }
                public QuickFix.Fields.PutOrCall putOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PutOrCall val) 
                { 
                    this.putOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return isSetPutOrCall();
                }
                
                public bool isSetPutOrCall() 
                { 
                    return isSetField(Tags.PutOrCall);
                }
                public QuickFix.Fields.StrikePrice strikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePrice val) 
                { 
                    this.strikePrice = val;
                }
                
                public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePrice val) 
                { 
                    return isSetStrikePrice();
                }
                
                public bool isSetStrikePrice() 
                { 
                    return isSetField(Tags.StrikePrice);
                }
                public QuickFix.Fields.OptAttribute optAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptAttribute val) 
                { 
                    this.optAttribute = val;
                }
                
                public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptAttribute val) 
                { 
                    return isSetOptAttribute();
                }
                
                public bool isSetOptAttribute() 
                { 
                    return isSetField(Tags.OptAttribute);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return isSetSecurityExchange();
                }
                
                public bool isSetSecurityExchange() 
                { 
                    return isSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.Issuer issuer
                { 
                    get 
                    {
                        QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Issuer val) 
                { 
                    this.issuer = val;
                }
                
                public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Issuer val) 
                { 
                    return isSetIssuer();
                }
                
                public bool isSetIssuer() 
                { 
                    return isSetField(Tags.Issuer);
                }
                public QuickFix.Fields.SecurityDesc securityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityDesc val) 
                { 
                    this.securityDesc = val;
                }
                
                public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityDesc val) 
                { 
                    return isSetSecurityDesc();
                }
                
                public bool isSetSecurityDesc() 
                { 
                    return isSetField(Tags.SecurityDesc);
                }
            
            }
            public class LinesOfText : Group
            {
                public LinesOfText() 
                  :base( Tags.LinesOfText, Tags.Text, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Text, 0};
                            public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Text val) 
                { 
                    return isSetText();
                }
                
                public bool isSetText() 
                { 
                    return isSetField(Tags.Text);
                }
            
            }
        }
    }
}
