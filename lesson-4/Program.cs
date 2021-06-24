using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2-dimension Array


            //// מערך דו מימדי. כמו מערך שמורכב מ-3 מערכים, שלכל אחד מהם 4 איברים
            //int[,] myDemArr1 = new int[3, 4];

            //Console.WriteLine(myDemArr1.Length); // יחזיר לי את מס' האיברים במערך הדו-מימדי. במקרה זה 12

            //Console.WriteLine(myDemArr1.GetLength(0)); // מחזיר לי מה הגודל של המערך (מימד ראשון - כי ביקשתי את 0). במקרה זה 3
            //Console.WriteLine(myDemArr1.GetLength(1)); // מחזיר את הגודל של המימד השני (מימד ראשון - כי ביקשתי את 1) - 4

            //int[,] myDemArr = // new int[4, 3]
            //{ // כמו שבמערך רגיל יש אפשרות ישר לתת ערכים והמערך יווצר לפי מס' הערכים שנתתי
            //    {1,1,1 }, // אותו הדבר במערך דו מימדי, נתתי לו 4 פעמים מערך שכלל 3 איברים
            //    {2,2,2 }, // ולכן הוא יצר לי לבד
            //    {3,3,3 }, // new int[4, 3]
            //    {4,4,4 }
            //};


            #endregion

            #region לוח הכפל

            //int[,] kefel = new int[10, 10];

            //for (int i = 0; i < kefel.GetLength(0); i++)
            //{
            //    for (int j = 0; j < kefel.GetLength(1); j++)
            //    {
            //        kefel[i, j] = (i + 1) * (j + 1);
            //        if (kefel[i, j] < 10)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write(" " + kefel[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region jagged Array

            // מערך משונן
            // בניגוד למערך דו מימדי, שהוא מערך אחד שכלול מ-2 מימדים, ובעצם נוצרת מין טבלה של 4 שורות ו-3 עמודות
            // מערך משונן ייצור מס' מערכים כשלכל אחד מהם יכול להיות מס' אחר של איברים
            string[][] myJadArr = new string[3][]; // יצרתי 3 מערכים
            myJadArr[0] = new string[2] { "moshe", "david" }; // למערך הראשון [0] יהיו 2 איברים
            myJadArr[1] = new string[5] { "", "", "", "", "" }; // למערך השני [1] יהיו 5 איברים
            myJadArr[2] = new string[3] { "ran", "dani", "yossi" }; // למערך השלישי [2] יהיו 3 איברים

            Console.WriteLine(myJadArr.Length); // יחזיר לי את מס' האיברים במערך המשונן. במקרה זה 10
            Console.WriteLine();

            #endregion
        }
    }
}
