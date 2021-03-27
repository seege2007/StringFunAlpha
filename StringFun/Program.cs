using System;
using System.IO;
using System.Text.RegularExpressions;

namespace StringFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // var bstring = "\"<span id=\"btnClaimants\" onclick="if (m_bPromptMode == 1) { alert(&quot; You must respond either Yes or No to the prompt before continuing.&quot;); this.blur(); return (false); }; __popupNode(this, '../cs/Menu?sMenuID=CLAIMS_DESKTOP_ECSMenus_SelectedParticipantLevel_Auto&amp;sClaimStatus=O&amp;tAdditionalParams=CLAIM_STATE%3D43&amp;sPartyTypeCode=I&amp;sClaimFileType=R&amp;sParticipantType=C&amp;sParticipantRole=O&amp;tAdditionalParams=SUBROGATION_RESPONSIBLE%3Dfalse&amp;sFullName=BOBBY&nbsp;JACK&nbsp;JONES&amp;sClaimID=QVWV9QYXR3YD0&amp;sProductLine=A&amp;tAdditionalParams=CLAIM_STATE%3D43&amp;sParticipantID=5', '/ccs/screens/en/xsl/cs/MSIE/Menu.xsl', '333', '134', event);" style="cursor:pointer"><img src=\"../../images/imgMenuLaunch.gif\" 
            //               style="\border:0px;\"></span>"\";

           // string pattern = "([a-zA-Z]{2,})";

          //  Regex regex = new Regex(@"sTaskID=(\w+)");

           // Regex regex2 = new Regex(@"FC(\w+)");

           // Regex regex3 = new Regex(@"([a-zA-Z]{2,}\s[a-zA-z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)");

           // Regex regex4 = new Regex(@"(([A-Za-z]{2,})\s[A-Za-z]?\s([A-Za-z]{2,}))(?!\()");

           // Regex regex5 = new Regex(@"([7][0-5])|([0-6][1-9])|([1-6][0]))(\-?|\ ?)[0-9a-zA-Z]{4}(\-?|\ ?)[0-9a-zA-Z]{3}");

            string clmnumber = "18-2154-5X8";

            string output = Regex.Replace(clmnumber, @"-", "");

            var strglength = output.Length;

            if (output.Length == 9)
                Console.WriteLine("Good Claim Number");
            else
                Console.WriteLine("Bad Claim Number");

            Console.WriteLine("Claim Number and length " + output + " " + strglength);

            //^\d{5}(?:[-\s]\d{4})?$

            //https://regex101.com/r/IhtjyT/1

            string address = "75235- Firest Park Rod 12345-3455";

            string[] zipcodes = new String[2];

            int idx = 0; 

            Regex regex = new Regex(@"(\d{5})");

            var match = regex.Matches(address);

            //string v = match.Groups[0].Value;
            //string c = match.Groups[1].Value;

            foreach(var mtch in match)
            {
                zipcodes[idx] = mtch.ToString();
                idx++;    
            }

            /*  using (StreamReader reader = new StreamReader(@"C:\Users\chrsj\Desktop\TaskFile2.txt"))
               {
                   string line;
                   string[] docarray = new String[4];

                   while ((line = reader.ReadLine()) != null)
                   {
                       Match match = regex.Match(line);
                       Match match2 = regex2.Match(line);
                       Match match3 = regex3.Match(line);
                       Match match4 = regex4.Match(line);

                      if (match.Success || match2.Success || match3.Success || match4.Success)
                       {
                           // Write original line and the value.
                           string v = match.Groups[1].Value;
                           string x = match2.Groups[1].Value;
                           string y = match3.Groups[1].Value;
                           string z = match4.Groups[2].Value;
                           // Console.WriteLine(line);
                           docarray[0] = v;
                           docarray[1] = x;
                           docarray[2] = y;
                           docarray[3] = z; 

                           Console.WriteLine("Task ID= " + docarray[0]);
                           Console.WriteLine("FC:" + docarray[1]);
                           Console.WriteLine("Name:" + docarray[2]);
                           Console.WriteLine("Name2:" + docarray[3]);


                       }
                   }
               }*/



            Console.ReadLine();
        }
    }
}
 