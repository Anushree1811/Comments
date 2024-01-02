using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string AppraisalComment1 = null;
            string AppraisalComment2 = "Test 1";
            string AppraisalComment3 = null;

            string M_RequestdotX26 =  !string.IsNullOrEmpty(AppraisalComment1)
                                        ? AppraisalComment1
                                        : (!string.IsNullOrEmpty(AppraisalComment2)
                                            ? AppraisalComment2
                                            : AppraisalComment3);


            string M_RequestdotX27 = !string.IsNullOrEmpty(AppraisalComment1)
                                    ? (!string.IsNullOrEmpty(AppraisalComment2)
                                        ? AppraisalComment2
                                        : AppraisalComment3)
                                    : (!string.IsNullOrEmpty(AppraisalComment2)
                                        ? AppraisalComment3
                                        : string.Empty);

            string M_RequestdotX28 = !string.IsNullOrEmpty(AppraisalComment1)
                                    ? (!string.IsNullOrEmpty(AppraisalComment2)
                                        ? AppraisalComment3
                                        : string.Empty)
                                    : string.Empty;

            Console.WriteLine("M_RequestdotX26 " + M_RequestdotX26);
            Console.WriteLine("M_RequestdotX27 " + M_RequestdotX27);
            Console.WriteLine("M_RequestdotX28 " + M_RequestdotX28);
        }
    }
}