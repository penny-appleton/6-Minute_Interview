﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumberLib
{
    public class PhoneNumber
    {
        public static int Usa = 0;
        public static readonly string[] CountryCodes = {
                                    "1", "20", "212", "213", "216", "218", "220", "221", "222", "223", 
                                    "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", 
                                    "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", 
                                    "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", 
                                    "254", "255", "256", "257", "258", "260", "261", "262", "263", "264", 
                                    "265", "266", "267", "268", "269", "27", "290", "291", "297", "298", 
                                    "299", "30", "31", "32", "33", "34", "350", "351", "352", "353", 
                                    "354", "355", "356", "357", "358", "359", "36", "370", "371", "372", 
                                    "373", "374", "375", "376", "377", "378", "380", "381", "385", "386", 
                                    "387", "389", "39", "40", "41", "420", "421", "423", "43", "44", 
                                    "45", "46", "47", "48", "49", "500", "501", "502", "503", "504", 
                                    "505", "506", "507", "508", "509", "51", "52", "53", "5399", "54", 
                                    "55", "56", "57", "58", "590", "591", "592", "593", "594", "595", 
                                    "596", "597", "598", "599", "60", "61", "618", "62", "63", "64", 
                                    "65", "66", "670", "672", "673", "674", "675", "676", "677", "678", 
                                    "679", "680", "681", "682", "683", "684", "685", "686", "687", "688", 
                                    "689", "690", "691", "692", "7", "808", "81", "82", "84", "850", 
                                    "852", "853", "855", "856", "86", "870", "871", "872", "873", "874", 
                                    "878", "880", "881", "8816", "8817", "88213", "88216", "886", "90", "91", 
                                    "92", "93", "94", "95", "960", "961", "962", "963", "964", "965", 
                                    "966", "967", "968", "970", "971", "972", "973", "974", "975", "976", 
                                    "977", "98", "992", "993", "994", "995", "996", "998"}; 

        private static readonly List<string> Reasons = new List<string>(){"Phone Number Too Long or Too Short", "US Number must be length 10", "Unknown Country Code"};

         /** The original value. */
         private string originalValue = null;

        // An index into the COUNTRY_CODES array
        private readonly int _countryCodeIndex = Usa;
        private readonly string _strippedValue = null;
        private readonly string _invalidReason = null;

        public PhoneNumber(string originalValue)
        {
        }
        /**************************************************************************/
        /* Reduce the string to just numbers */
        private static string StripPhoneNumber(string number)
        {
            return null;
        }
        /**************************************************************************/
        private static int GetCountryCodeIndex(string strippedNumber)
        {
            return -1;
        }
        /**************************************************************************/
        private static string Validate(int countryCodeIndex, string stripedNumber)
        {
            return (countryCodeIndex == Usa) ? ValidateNorthAmerican(countryCodeIndex, stripedNumber) : ValidateInternational(countryCodeIndex, stripedNumber);
        }
        /**************************************************************************/
        /*
         *  International Phone number must be between 9-15 chars
         */
        private static string ValidateInternational(int countryCodeIndex, string strippedNumber)
        {
            return null;
        }
        /**************************************************************************/
        private static string ValidateNorthAmerican(int countryCodeIndex, string strippedNumber)
        {
            return ExtractPhoneBody(countryCodeIndex, strippedNumber).Length == 10 ? null : Reasons[1];
        }
        /**************************************************************************/
        private static string ExtractPhoneBody(int countryCodeIndex, string strippedNumber)
        {
            return null;
        }
        /**************************************************************************/
        private static string GetValueAsNorthAmerican(int countryCodeIndex, string stripped)
        {
            return null;
        }
        /**************************************************************************/
        private static string GetValueAsInternational(int countryCodeIndex, string stripped)
        {
            return null;
        }
        /**************************************************************************/
        public string GetValueAsNorthAmerican()
        {
            return GetValueAsNorthAmerican(_countryCodeIndex, _strippedValue);
        }
        /**************************************************************************/
        public string GetValueAsInternational()
        {
            return GetValueAsInternational(_countryCodeIndex, _strippedValue);
        }
        /**************************************************************************/
        public bool IsValid()
        {
            return (_invalidReason == null);
        }
        /**************************************************************************/
        public string GetInvalidReason()
        {
            return _invalidReason;
        }
        /**************************************************************************/
        public bool IsNorthAmericanNumber()
        {
            return _countryCodeIndex == Usa;
        }
        /**************************************************************************/
        public string GetOriginalText()
        {
            return originalValue;
        }
        /***********************************************************************/
        public string GetStrippedNumber()
        {
            return _strippedValue;
        }
        /**************************************************************************/
        /**************************************************************************/
    }
}
