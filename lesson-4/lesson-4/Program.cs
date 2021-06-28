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
            #region טיפ מערך

            //// דרך מהירה לכתוב הצבת ערך ל-10 איברים במערך

            //int[] myArr = new int[10];
            //int counter = 0;
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter] = int.Parse(Console.ReadLine());

            //// ולהדפיס אותם מהסוף להתחלה

            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);

            #endregion

            #region 2-dimension Array, Length, GetLength


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

            Console.WriteLine(myJadArr.Length); // יחזיר לי את מס' האיברים במערך המשונן. במקרה זה 10. לא עובד, מחזיר 3.
                                                // צריך לבדוק איך נכון לכתוב את הפקודה הזו...

            #endregion

            #region Sort Arrays

            //int[] arrForSort = { 13, 5, 2, 8, 1 };
            //Array.Sort(arrForSort); // פונקציה שמסדרת את הערכים במערך מהקטן לגדול. היא פועלת על המערך שביקשתי בסוגריים
            //// ומשנה ממש את סדר הערכים בתוכו

            //for (int i = 0; i < arrForSort.Length; i++)
            //{
            //    Console.WriteLine(arrForSort[i]);
            //}

            ////string  A-Z
            //string[] myStrForSort = { "Soso", "David", "Avi", "Abigail", "add" };
            //Array.Sort(myStrForSort); // על סטרינג, הפונקציה ממיינת לפי סדר האותיות הראשונות - abc

            //for (int i = 0; i < myStrForSort.Length; i++)
            //{
            //    Console.WriteLine(myStrForSort[i]);
            //}


            #endregion

            #region Rank Property

            //char[,,,] charsDim = new char[5, 2, 3, 4];
            //Console.WriteLine(charsDim.Rank);// Rank - מחזירה לי כמה מימדים יש במערך מסוים. במקרה זה - 4

            #endregion

            #region IndexOf Method

            //double[] dblArr = { 3.2, 4.5, 7.2, 8 };

            //int index = Array.IndexOf(dblArr, 7.2); // פונקציה שבודקת במערך המבוקש (במקרה הזה dblArr)
            //// האם יש בתוכו ערך מסוים, במקרה זה 7.2, אם כן היא תחזיר את האינדקס של האיבר במערך שמכיל את הערך המבוקש
            //// אם לא נמצא הערך, היא תחזיר:
            //// -1

            //double num = double.Parse(Console.ReadLine());
            //int index2 = Array.IndexOf(dblArr, num);
            //if (index2 == -1)
            //{
            //    Console.WriteLine("Try Another Number");
            //}
            //else
            //{
            //    Console.WriteLine(index2);
            //}

            #endregion

        }
    }
}
